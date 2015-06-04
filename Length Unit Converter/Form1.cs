using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Length_Unit_Converter
{
    public partial class MainWindow : Form
    {    
        
        public MainWindow()
        {
            InitializeComponent();
            PopulateList();
        }

        //Set lists to start at item 0
        public void PopulateList()
        {
            unit_list_1.SetSelected(0, true);
            unit_list_2.SetSelected(0, true);


        }

        //Actions: After any change of value or unit. The data will be recalculated

        private void unit_list_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetData();
        }

        private void unit_list_2_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetData();
        }

        private void num_input_1_ValueChanged(object sender, EventArgs e)
        {
            GetData();
        }

        private void num_input_2_ValueChanged(object sender, EventArgs e)
        {
            GetData();
        }

        public void GetData()
        {
            decimal from_value = num_input_1.Value;

            if (from_value > 0)
            {
                if (unit_list_1.SelectedIndex >= 0 && unit_list_2.SelectedIndex >= 0)
                {
                    try
                    {
                        string unit1 = unit_list_1.GetItemText(unit_list_1.SelectedItem);
                        string unit2 = unit_list_2.GetItemText(unit_list_2.SelectedItem);

                        System.Console.Write(unit1);

                        switch(unit1)
                        {
                            case "Kilómetros (Km)":
                                MeterHandler(unit2, from_value, 1000m);
                                break;

                            case "Metros (m)":
                                MeterHandler(unit2, from_value, 1m);
                                break;

                            case "Centímetros (cm)":
                                MeterHandler(unit2, from_value, 0.01m);
                                break;

                            case "Milímetros (mm)":
                                MeterHandler(unit2, from_value, 0.001m);
                                break;

                            case "Millas (mi)":
                                MileHandler(unit2, from_value);
                                break;

                            case "Pies (ft)":
                                FeetHandler(unit2, from_value);
                                break;

                            case "Pulgadas (in)":
                                InchHandler(unit2, from_value);
                                break;

                            case "Yardas (yd)":
                                YardHandler(unit2, from_value);
                                break;
                        }
                    }
                    catch (System.NullReferenceException e)
                    {

                    }
                }
            }
        }

        //Handlers

        public void YardHandler(string to_convert, decimal init_value)
        {
            decimal output_value = 0m;
            switch (to_convert)
            {
                case "Centímetros (cm)":
                    output_value = init_value * 0.9144m * 100m;
                    break;

                case "Kilómetros (Km)":
                    output_value = (init_value * 0.9144m) / 1000m;
                    break;

                case "Milímetros (mm)":
                    output_value = init_value * 0.9144m * 1000m;
                    break;

                case "Millas (mi)":
                    output_value = init_value / 1760m;
                    break;

                case "Pies (ft)":
                    output_value = init_value * 3m;
                    break;

                case "Pulgadas (in)":
                    output_value = init_value * 36m;
                    break;

                case "Metros (m)":
                    output_value = init_value * 0.9144m;
                    break;

                default:
                    output_value = init_value;
                    break;
            }
            num_input_2.Value = decimal.Truncate(output_value * 100m) / 100m;
        }

        public void InchHandler(string to_convert, decimal init_value)
        {
            decimal output_value = 0m;
            switch (to_convert)
            {
                case "Centímetros (cm)":
                    output_value = init_value * 0.0254m * 100m;
                    break;

                case "Kilómetros (Km)":
                    output_value = (init_value * 0.0254m) / 1000m;
                    break;

                case "Milímetros (mm)":
                    output_value = init_value * 0.0254m * 1000m;
                    break;

                case "Millas (mi)":
                    output_value = init_value / 63360m;
                    break;

                case "Pies (ft)":
                    output_value = init_value / 12m;
                    break;

                case "Yardas (yd)":
                    output_value = init_value / 36m;
                    break;

                case "Metros (m)":
                    output_value = init_value * 0.0254m;
                    break;

                default:
                    output_value = init_value;
                    break;
            }
            num_input_2.Value = decimal.Truncate(output_value * 100m) / 100m;
        }

        public void FeetHandler(string to_convert, decimal init_value)
        {
            decimal output_value = 0m;
            switch (to_convert)
            {
                case "Centímetros (cm)":
                    output_value = init_value * 0.3048m * 100m;
                    break;

                case "Kilómetros (Km)":
                    output_value = (init_value * 0.3048m) / 1000m;
                    break;

                case "Milímetros (mm)":
                    output_value = init_value * 0.3048m * 1000m;
                    break;

                case "Millas (mi)":
                    output_value = init_value / 5280m;
                    break;

                case "Pulgadas (in)":
                    output_value = init_value * 12m;
                    break;

                case "Yardas (yd)":
                    output_value = init_value * 0.333333m;
                    break;

                case "Metros (m)":
                    output_value = init_value * 0.3048m;
                    break;

                default:
                    output_value = init_value;
                    break;
            }
            num_input_2.Value = decimal.Truncate(output_value * 100m) / 100m;
        }

        public void MileHandler(string to_convert, decimal compare_value)
        {
            decimal output_value = 0m;
            switch(to_convert)
            {
                case "Centímetros (cm)":
                    output_value = compare_value * 1609.344m * 100m;
                    break;

                case "Kilómetros (Km)":
                    output_value = compare_value * 1.609344m;
                    break;

                case "Milímetros (mm)":
                    output_value = compare_value * 1609.344m * 1000m;
                    break;

                case "Pies (ft)":
                    output_value = compare_value * 5280m;                    
                    break;

                case "Pulgadas (in)":
                    output_value = compare_value * 63360m;
                    break;

                case "Yardas (yd)":
                    output_value = compare_value * 1760m;
                    break;

                case "Metros (m)":
                    output_value = compare_value * 1609.344m;
                    break;

                default:
                    output_value = compare_value;
                    break;
            }

            num_input_2.Value = decimal.Truncate(output_value * 100m) / 100m;
        }

        public void MeterHandler(string to_convert, decimal compare_value, decimal init_value)
        {
            decimal output_value = 0;
            init_value *= compare_value;
            switch(to_convert)
            {
                case "Centímetros (cm)":
                    output_value = init_value * 100m;
                    break;
                    
                case "Kilómetros (Km)":
                    output_value = init_value / 1000m;
                    break;

                case "Milímetros (mm)":
                    output_value = init_value * 1000m;
                    break;
                
                case "Millas (mi)":
                    output_value = init_value / 1609.344m;
                    break;

                case "Pies (ft)":
                    output_value = init_value / 0.3048m;
                    break;

                case "Pulgadas (in)":
                    output_value = init_value / 0.0254m;
                    break;

                case "Yardas (yd)":
                    output_value = init_value / 0.9144m;
                    break;

                case "Metros (m)":
                    output_value = init_value;
                    break;
            }

            num_input_2.Value = decimal.Truncate(output_value * 100m) / 100m;
        }


    }
}
