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
            var objGalileo = new Galileo.ReadData();
            for(int i=0;i < 400;i++)
            {
                var sensorAData = objGalileo.SensorA((double)Mu.Value, (double)Sigma.Value);
                listSensorA.AddLast(sensorAData);
                var sensorBDAta = objGalileo.SensorB((double)Mu.Value, (double)Sigma.Value);
                listSensorB.AddLast(sensorBDAta);
            }
        }

        /// <summary>
        /// 4.3 4.3	Create a custom method called “ShowAllSensorData” which will display both LinkedLists in a ListView. 
        /// Add column titles “Sensor A” and “Sensor B” to the ListView. The input parameters are empty, and the return type is void.
        /// </summary>
        private void ShowAllSensorData()
        {
            listViewData.Items.Clear();

            for(int i =0; i < listSensorA.Count; i++)
            {
                ListViewItem row = new ListViewItem(listSensorA.ElementAt(i).ToString());
                row.SubItems.Add(new ListViewItem.ListViewSubItem(row, listSensorB.ElementAt(i).ToString()));
                listViewData.Items.Add(row);
            }

        }
        /// <summary>
        /// 4.4	Create a button and associated click method that will call the LoadData and ShowAllSensorData methods.
        /// The input parameters are empty, and the return type is void.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLoadSensorData_Click(object sender, EventArgs e)
        {
            LoadData();
            ShowAllSensorData();
        }
        #endregion

        
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
           for(int i=0; i < NumberOfNodes(sensorList); i++)
            {
                listbox.Items.Add(sensorList.ElementAt(i).ToString());
            }
        }
    }

}
