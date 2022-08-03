using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Galileo;
using System.Diagnostics;

/// Created by Atit
/// Version 1
/// Started date 21/07/2022
/// This application process the Satellite Data for Malin Space Science System.  
/// application has used LinkedList<T> to store the  data from satellite sensor A and satellite SensorB.
/// The application will sort and search the data sets recorded during the satellite operation.
/// Galileo library will be used for the project.
namespace MalinSpaceScience
{
    public partial class MalinSpaceScience : Form
    {
        public MalinSpaceScience()
        {
            InitializeComponent();
        }
        #region GLOBAL METHODS
        /// 4.1 Create two data structures using the LinkedList<T> class from the C# Systems.Collections.Generic namespace. 
        /// The data must be of type “double”; you are not permitted to use any additional classes, nodes, pointers or data structures (array, list, etc) in the implementation of this application. 
        /// The two LinkedLists of type double are to be declared as global within the “public partial class”.
        /// </summary>
        private LinkedList<double> listSensorA = new LinkedList<double>();
        private LinkedList<double> listSensorB = new LinkedList<double>();

        //4.2 Create a method called “LoadData” which will populate both LinkedLists. 
        private void LoadData()
        {
            listSensorA.Clear();
            listSensorB.Clear();
            var objGalileo = new Galileo.ReadData();
            for (int i = 0; i < 400; i++)
            {
                var sensorAData = objGalileo.SensorA((double)Mu.Value, (double)Sigma.Value);
                listSensorA.AddLast(sensorAData);
                var sensorBDAta = objGalileo.SensorB((double)Mu.Value, (double)Sigma.Value);
                listSensorB.AddLast(sensorBDAta);
            }
        }

        /// 4.3 4.3	Create a custom method called “ShowAllSensorData” which will display both LinkedLists in a ListView. 
        /// Add column titles “Sensor A” and “Sensor B” to the ListView. The input parameters are empty, and the return type is void.
        private void ShowAllSensorData()
        {
            listViewData.Items.Clear();
            for (int i = 0; i < listSensorA.Count; i++)
            {
                ListViewItem row = new ListViewItem(listSensorA.ElementAt(i).ToString());
                row.SubItems.Add(new ListViewItem.ListViewSubItem(row, listSensorB.ElementAt(i).ToString()));
                listViewData.Items.Add(row);
            }

        }
        /// 4.4	Create a button and associated click method that will call the LoadData and ShowAllSensorData methods.
        /// The input parameters are empty, and the return type is void.
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLoadSensorData_Click(object sender, EventArgs e)
        {
            clearAllListBox();
            clearAllTextBoxesSensorA();
            clearAllTextBoxesSensorB();
            LoadData();
            ShowAllSensorData();
        }
        #endregion

        #region SORT AND SEARCH

        /// 4.7	Create a method called “SelectionSort” which has a single input parameter of type LinkedList, while the calling code argument is the linkedlist name.
        /// The method code must follow the pseudo code supplied below in the Appendix. The return type is Boolean.
        /// <param name="sensorList">has a parameter of linkedlist<double> </param>
        /// <returns>method return the boolean of true and false</returns>
        private bool SelectionSort(LinkedList<double> sensorList)
        {
            bool sorted = false;
            int min;
            int max = NumberOfNodes(sensorList);
            for (int i = 0; i < max; i++)
            {
                sorted = false;
                min = i;
                for (int j = i + 1; j < max; j++)
                {
                    if (sensorList.ElementAt(j) < sensorList.ElementAt(min))
                    {
                        min = j;
                    }
                }
                LinkedListNode<double> currentMin = sensorList.Find(sensorList.ElementAt(min));
                LinkedListNode<double> currentI = sensorList.Find(sensorList.ElementAt(i));

                var temp = currentMin.Value;
                currentMin.Value = currentI.Value;
                currentI.Value = temp;
                sorted = true;

            }
            return sorted;
        }

        /// 4.8	Create a method called “InsertionSort” which has a single parameter of type LinkedList, while the calling code argument is the linkedlist name. 
        /// The method code must follow the pseudo code supplied below in the Appendix. The return type is Boolean.
        /// <param name="sensorList">takes linkedList<double> as paramter</param>
        /// <returns>boolean value confirming whether the list is sorted or not</returns>
        private bool InsertionSort(LinkedList<double> sensorList)
        {
            bool sorted = false;
            int max = NumberOfNodes(sensorList);

            for (int i = 0; i < max - 1; i++)
            {
                sorted = false;
                for (int j = i + 1; j > 0; j--)
                {
                    if (sensorList.ElementAt(j - 1) > sensorList.ElementAt(j))
                    {
                        LinkedListNode<double> current = sensorList.Find(sensorList.ElementAt(j));
                        LinkedListNode<double> currentMax = sensorList.Find(sensorList.ElementAt(j - 1));

                        var temp = current.Value;
                        current.Value = currentMax.Value;
                        currentMax.Value = temp;
                        sorted = true;
                    }
                }
            }
            return sorted;
        }

        //4.12	Create four button click methods that will sort the LinkedList using the Selection and Insertion methods
        private void btSensorASortSelection_Click(object sender, EventArgs e)
        {
            // create as instance of stopWatch
            //start the watch before sorting and stop after the sorting
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            SelectionSort(listSensorA);
            stopWatch.Stop();
            //Displays the data in the listbox
            DisplayListboxData(listSensorA, listBoxSensorA);
            //display the time under the corresponding textbox
            TimerAndDisplay(stopWatch, txSensorASortSelection);
        }

        private void btSensorBSortSelection_Click(object sender, EventArgs e)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            SelectionSort(listSensorB);
            stopWatch.Stop();
            DisplayListboxData(listSensorB, listBoxSensorB);
            TimerAndDisplay(stopWatch, txSensorBSortSelection);
        }

        private void btSensorASortInsertion_Click(object sender, EventArgs e)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            InsertionSort(listSensorA);
            stopWatch.Stop();
            DisplayListboxData(listSensorA, listBoxSensorA);
            TimerAndDisplay(stopWatch, txSensorASortInsertion);
        }

        private void btSensorBSortInsertion_Click(object sender, EventArgs e)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            InsertionSort(listSensorB);
            stopWatch.Stop();
            DisplayListboxData(listSensorB, listBoxSensorB);
            TimerAndDisplay(stopWatch, txSensorBSortInsertion);
        }

        /// 4.9	Create a method called “BinarySearchIterative” which has the following four parameters:
        /// LinkedList, SearchValue, Minimum and Maximum. This method will return an integer of the linkedlist element from a successful search or the nearest neighbour value. 
        /// <param name="sensorList">linkedlist in which the search is conducted</param>
        /// <param name="searchValue">value which is searched in the list</param>
        /// <param name="min">the minimum value</param>
        /// <param name="max">the maximum value</param>
        /// <returns>it returns the index of list in which the search value is located</returns>
        private int BinarySearchIterative(LinkedList<double> sensorList, int searchValue, int min, int max)
        {
            while (min <= max)
            {

                int mid = (min + max) / 2;

                if (searchValue == sensorList.ElementAt(mid))
                {
                    return ++mid;
                }
                else if (searchValue < sensorList.ElementAt(mid))
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }

            }
            return min;
        }

       
        /// 4.10	Create a method called “BinarySearchRecursive” which has the following four parameters:
        /// LinkedList, SearchValue, Minimum and Maximum. This method will return an integer of the linkedlist element from a successful search or the nearest neighbour value
        /// <param name="sensorList">linkedlist in which the search is conducted</param>
        /// <param name="searchValue">value which is searched in the list</param>
        /// <param name="min">the minimum value</param>
        /// <param name="max">the maximum value</param>
        /// <returns>it returns the index of list in which the search value is located</returns>
        private int BinarySearchRecursive(LinkedList<double> sensorList, int searchValue, int min, int max)
        {
            if (min <= max)
            {
                int mid = (min + max) / 2;
                if (searchValue == sensorList.ElementAt(mid))
                {
                    return mid;
                }
                else if (searchValue < sensorList.ElementAt(mid))
                {
                    return BinarySearchRecursive(sensorList, searchValue, min, mid - 1);
                }
                else
                {
                    return BinarySearchRecursive(sensorList, searchValue, mid + 1, max);
                }
            }
            return min;
        }

        //Button click event to execute the Iterative search for Sensor A
        private void btSensorASearchIterative_Click(object sender, EventArgs e)
        {
            try
            {
                InsertionSort(listSensorA);
                DisplayListboxData(listSensorA, listBoxSensorA);
                int target = int.Parse(txTargetSA.Text);
                var stopWatch = new Stopwatch();
                stopWatch.Start();
                int idx = BinarySearchIterative(listSensorA, target, 0, NumberOfNodes(listSensorA));
                stopWatch.Stop();
                highLightListboxData(idx, listBoxSensorA, listSensorA);
                TimerAndDisplay(stopWatch, txSensorASearchIterative);
            }
            catch (Exception)
            {
                MessageBox.Show("!User Error: No Data in Search Target");
            }

        }


        //Button click event to execute the Recursive search for Sensor A
        private void btSensorASearchRecursive_Click(object sender, EventArgs e)
        {
            try
            {
                InsertionSort(listSensorA);
                DisplayListboxData(listSensorA, listBoxSensorA);
                int target = int.Parse(txTargetSA.Text);
                var stopWatch = new Stopwatch();
                stopWatch.Start();
                int idx = BinarySearchIterative(listSensorA, target, 0, NumberOfNodes(listSensorA));
                stopWatch.Stop();
                highLightListboxData(idx, listBoxSensorA, listSensorA);
                TimerAndDisplay(stopWatch, txSensorASearchRecursive);
            }
            catch (Exception)
            {
                MessageBox.Show("!User Error: No Data in Search Target");
            }
        }

        //Button click event to execute the Iterative search for Sensor B
        private void btSensorBSearchIterative_Click(object sender, EventArgs e)
        {
            try
            {
                InsertionSort(listSensorB);
                DisplayListboxData(listSensorB, listBoxSensorB);
                int target = int.Parse(txTargetSB.Text);
                var stopWatch = new Stopwatch();
                stopWatch.Start();
                int idx = BinarySearchIterative(listSensorB, target, 0, NumberOfNodes(listSensorB));
                stopWatch.Stop();
                highLightListboxData(idx, listBoxSensorB, listSensorB);
                TimerAndDisplay(stopWatch, txSensorBSearchIterative);
            }
            catch (Exception)
            {
                MessageBox.Show("!User Error: No Data in Search Target");
            }

        }

        //Button click event to execute the Recursive search for Sensor B
        private void btSensorBSearchRecursive_Click(object sender, EventArgs e)
        {
            try
            {
                InsertionSort(listSensorB);
                DisplayListboxData(listSensorB, listBoxSensorB);
                int target = int.Parse(txTargetSB.Text);
                var stopWatch = new Stopwatch();
                stopWatch.Start();
                int idx = BinarySearchIterative(listSensorB, target, 0, NumberOfNodes(listSensorB));
                stopWatch.Stop();
                highLightListboxData(idx, listBoxSensorB, listSensorB);
                TimerAndDisplay(stopWatch, txSensorBSearchRecursive);
            }
            catch (Exception)
            {
                MessageBox.Show("!User Error: No Data in Search Target");
            }

        }
        #endregion

        #region UTILITIES

        /// 4.5	Create a method called “NumberOfNodes” that will return an integer which is the number of nodes(elements) in a LinkedList. 
        /// The method signature will have an input parameter of type LinkedList, and the calling code argument is the linkedlist name.
        /// <param name="sensorList"> linkedlist for sensor A abd Sensor B</param>
        /// <returns>number of Nodes in the linkedlist</returns>
        private int NumberOfNodes(LinkedList<double> sensorList)
        {
            return sensorList.Count;
        }

        /// 4.6	Create a method called “DisplayListboxData” that will display the content of a LinkedList inside the appropriate ListBox.
        /// The method signature will have two input parameters; a LinkedList, and the ListBox name.  
        /// The calling code argument is the linkedlist name and the listbox name.
        /// <param name="sensorList">linkedList from any sensor</param>
        /// <param name="listbox">listbox to display the appropiate sensor processed data</param>
        private void DisplayListboxData(LinkedList<double> sensorList, ListBox listbox)
        {
            listbox.Items.Clear();
            for (int i = 0; i < NumberOfNodes(sensorList); i++)
            {
                listbox.Items.Add(sensorList.ElementAt(i).ToString());
            }
        }


        /// This method will select and highlight the search value and other 4 nearest number in listbox.
        /// <param name="idx">the index of the list that is found by search method</param>
        /// <param name="listBoxSensor">The listbox in which the item to highlighted</param>
        /// <param name="linkListSensor">the linkedlist from where the index number is returned</param>
        private void highLightListboxData(int idx, ListBox listBoxSensor, LinkedList<double> linkListSensor)
        {
            // clear the listbox first
            listBoxSensor.ClearSelected();
            // create the node of the index in the list, one for forward and another for backward
            LinkedListNode<double> nodeForward = linkListSensor.Find(linkListSensor.ElementAt(idx));
            LinkedListNode<double> nodeBackward = linkListSensor.Find(linkListSensor.ElementAt(idx));
            int counter = 4;
            int down = 1;
            int up = 1;
            //highlight the index in the listbox, and other 4 will be selected by the while loop below.
            listBoxSensor.SelectedIndex = idx;
            while (counter > 0)
            {
                //check if there is any element in next node
                if (nodeForward.Next != null)
                {
                    listBoxSensor.SelectedIndex = idx + down;
                    down++;
                    counter--;
                    // to move the node forward
                    nodeForward = nodeForward.Next;
                }

                //check if there is any element in previous node
                if (nodeBackward.Previous != null)
                {
                    listBoxSensor.SelectedIndex = idx - up;
                    up++;
                    counter--;
                    //to move the node backward
                    nodeBackward = nodeBackward.Previous;
                }
            }
        }
      
        /// Method to display the elapse time taken to process the search or sort mechanism
        /// <param name="objStopWatch">stopwatch object</param>
        /// <param name="textBoxSensor">the textbox to display the elapse time</param>
        private void TimerAndDisplay(Stopwatch objStopWatch, TextBox textBoxSensor)
        {
            //this will only executed for the search buttons
            if (textBoxSensor == txSensorASearchIterative || textBoxSensor == txSensorASearchRecursive || textBoxSensor == txSensorBSearchIterative || textBoxSensor == txSensorBSearchRecursive)
            {
                var tick = objStopWatch.ElapsedTicks;
                textBoxSensor.Text = tick.ToString() + " Ticks";
            }
            //this will only executed for the sort buttons
            else
            {
                var miliSeconds = objStopWatch.ElapsedMilliseconds;
                textBoxSensor.Text = miliSeconds.ToString() + " ms";
            }
        }

        // To clear the data in the listbox A and B
        private void clearAllListBox()
        {
            listBoxSensorA.Items.Clear();
            listBoxSensorB.Items.Clear();
        }

        //This will clear all the items in the Sensor A column
        private void clearAllTextBoxesSensorA()
        {
            txTargetSA.Clear();
            txSensorASearchIterative.Clear();
            txSensorASearchRecursive.Clear();
            txSensorASortInsertion.Clear();
            txSensorASortSelection.Clear();
        }

        //This will clear all the items in the Sensor B column
        private void clearAllTextBoxesSensorB()
        {
            txTargetSB.Clear();
            txSensorBSearchIterative.Clear();
            txSensorBSearchRecursive.Clear();
            txSensorBSortInsertion.Clear();
            txSensorBSortSelection.Clear();
        }

        //Key press event in the textbox so that user can only input digit number
        private void txTargetSA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txTargetSB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        /// This method returns the minimum and maximum value in the linkedlist
        /// <param name="listSensor">linkelist from which the max and min range is returned</param>
        /// <returns>returns the tuple containing min and max value</returns>
        private (int, int) minMaxValueList(LinkedList<double> listSensor)
        {
            try
            {
                int min = (int)listSensor.Min();
                int max = (int)listSensor.Max();
                return (min, max);
            }
            catch (Exception)
            {
                return (-1, -1);
            }

        }

        ///This method is used to validate the textbox data that is provided from the user,it will return false when the data entered is not withing the range of the linkedlist 
        /// <param name="textBox">textbox from which the data is taken</param>
        /// <param name="linkedList">linkedlist that that is used for the search</param>
        /// <param name="errorMessage">it will send out the feedback messages</param>
        /// <returns>return the bool value</returns>
        private bool ValidRange(TextBox textBox, LinkedList<double> linkedList, out string errorMessage)
        {
            if (!string.IsNullOrWhiteSpace(textBox.Text))
            {
                var (minimumValue, maximumValue) = minMaxValueList(linkedList);
                int target = int.Parse(textBox.Text);
                if (minimumValue == -1 || maximumValue == -1)
                {
                    errorMessage = string.Format("!ERROR: No Data Loaded in the Sensor");
                    return false;
                }
                if (target < minimumValue || target > maximumValue)
                {
                    errorMessage = string.Format("INPUT ERROR: Value must be in between {0}-{1}", minimumValue, maximumValue);
                    return false;
                }
                errorMessage = "";
                return true;

            }
            else
            {
                errorMessage = "Number not typed";
                return true;
            }

        }

        //Validating event in the textbox, it uses ValidRange() method for 
        private void txTargetSA_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidRange(txTargetSA, listSensorA, out string errorMessage))
            {
                // Cancel the event
                e.Cancel = true;
                txTargetSA.Clear();
                MessageBox.Show(errorMessage);
            }
        }

        //Validating event in the textbox, it uses ValidRange() method for 
        private void txTargetSB_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidRange(txTargetSB, listSensorB, out string errorMessage))
            {
                // Cancel the event
                e.Cancel = true;
                txTargetSB.Clear();
                MessageBox.Show(errorMessage);
            }
        }

        #endregion

    }
}
