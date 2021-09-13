using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealEstateAgent
{
    public partial class MainForm : Form
    {
        List<Estate> estates;
        Estate estate;
        int idCounter;

        public MainForm()
        {
            InitializeComponent();

            //Init visible controls
            labelPlotSize.Visible = false;
            tbPlotSize.Visible = false;
            panelRegister.Visible = false;
            panelAdress.Visible = false;

            //Init ComboBox for countries and type of estates
            cbCountry.DataSource = Enum.GetValues(typeof(Countries));
            cbTypes.DataSource = Enum.GetValues(typeof(TypeOfEstate));
            cbTypes.SelectedIndex = -1;

            // Init id counter
            idCounter = 0;

            //Init list of estates
            estates = new List<Estate>();
        }

        private void rbRental_CheckedChanged(object sender, EventArgs e)
        {
            labelPrice.Text = "Rent";
            tbFee.Visible = false;
            labelFee.Visible = false;
        }

        private void rbCondominium_CheckedChanged(object sender, EventArgs e)
        {
            labelPrice.Text = "Price";
            tbFee.Visible = true;
            labelFee.Visible = true;
        }

        private void rbOwnership_CheckedChanged(object sender, EventArgs e)
        {
            labelPrice.Text = "Price";
            tbFee.Visible = false;
            labelFee.Visible = false;
        }

        private void cbTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTypes.SelectedItem != null)
            {
                panelRegister.Visible = true;
                panelAdress.Visible = true;
                if (cbTypes.SelectedItem.ToString() == "Apartment")
                {
                    labelFloorOrName.Visible = true;
                    tbFloorOrName.Visible = true;
                    labelFloorOrName.Text = "Floor";
                    labelPlotSize.Visible = false;
                    tbPlotSize.Visible = false;
                    rbOwnership.Enabled = false;
                    rbOwnership.Checked = false;
                    rbCondominium.Enabled = true;
                    rbRental.Enabled = true;
                }
                else if (cbTypes.SelectedItem.ToString() == "School" || cbTypes.SelectedItem.ToString() == "University")
                {
                    labelFloorOrName.Visible = true;
                    tbFloorOrName.Visible = true;
                    labelFloorOrName.Text = "Name";
                    labelPlotSize.Visible = true;
                    tbPlotSize.Visible = true;
                    rbOwnership.Enabled = true;
                    rbCondominium.Enabled = false;
                    rbRental.Enabled = false;
                }
                else
                {
                    labelFloorOrName.Visible = false;
                    tbFloorOrName.Visible = false;
                    labelPlotSize.Visible = true;
                    tbPlotSize.Visible = true;
                    rbOwnership.Enabled = true;
                    rbCondominium.Enabled = false;
                    rbRental.Enabled = true;
                }

            }
            else
            {
                panelRegister.Visible = false;
                panelAdress.Visible = false;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            LegalForm chosenLegalForm = LegalForm.None;

            if (CheckFilledTextBoxes(panelAdress) && CheckFilledTextBoxes(panelRegister) && CheckLegalForm(ref chosenLegalForm))
            {
                //Counter to set unique ID for each estate
                idCounter++;

                Adress adress = CreateAdress();
                TypeOfEstate chosenEstateType;
                Enum.TryParse<TypeOfEstate>(cbTypes.SelectedValue.ToString(), out chosenEstateType);

                //Variables for chosen fields, try parsing those values after
                float chosenNrOfRooms;
                float chosenLivingArea;
                float chosenPrice;
                float chosenFee;
                float chosenPlotSize;
                int chosenFloor;

                if (!float.TryParse(tbRooms.Text.Trim(), out chosenNrOfRooms))
                {
                    MessageBox.Show("Number of rooms must be a numerical value");
                }
                else if (!float.TryParse(tbLivingArea.Text.Trim(), out chosenLivingArea))
                {
                    MessageBox.Show("Living area must be a numerical value");
                }
                else if (!float.TryParse(tbPrice.Text.Trim(), out chosenPrice))
                {
                    MessageBox.Show("Price must be a numerical value");
                }
                else
                {
                    switch (chosenEstateType)
                    {
                        case TypeOfEstate.School:
                            estate = new School(idCounter, adress, chosenLegalForm, tbFloorOrName.Text, chosenNrOfRooms, chosenLivingArea, chosenPrice);
                            break;
                        case TypeOfEstate.University:
                            estate = new University(idCounter, adress, chosenLegalForm, tbFloorOrName.Text, chosenNrOfRooms, chosenLivingArea, chosenPrice);
                            break;
                        case TypeOfEstate.Warehouse:
                            estate = new WareHouse(idCounter, adress, chosenLegalForm, chosenNrOfRooms, chosenLivingArea, chosenPrice);
                            break;
                        case TypeOfEstate.Store:
                            estate = new Store(idCounter, adress, chosenLegalForm, chosenNrOfRooms, chosenLivingArea, chosenPrice);
                            break;
                        case TypeOfEstate.Villa:
                            estate = new Villa(idCounter, adress, chosenLegalForm, chosenNrOfRooms, chosenLivingArea, chosenPrice);
                            break;
                        case TypeOfEstate.Rowhouse:
                            estate = new RowHouse(idCounter, adress, chosenLegalForm, chosenNrOfRooms, chosenLivingArea, chosenPrice);
                            break;
                        case TypeOfEstate.Apartment:
                            if (!int.TryParse(tbFloorOrName.Text.Trim(), out chosenFloor))
                            {
                                MessageBox.Show("Floor must be a numerical value");
                                return;
                            }
                            else
                            {
                                if (chosenLegalForm == LegalForm.LegalCondominium)
                                {
                                    if (!float.TryParse(tbFee.Text.Trim(), out chosenFee))
                                    {
                                        MessageBox.Show("Fee must be a numerical value");
                                        return;
                                    }
                                    else
                                    {
                                        estate = new Condominium(idCounter, adress, chosenLegalForm, chosenNrOfRooms, chosenLivingArea, chosenPrice, chosenFloor, chosenFee);
                                    }
                                }
                                else if (chosenLegalForm == LegalForm.LegalRental)
                                {
                                    estate = new Rental(idCounter, adress, chosenLegalForm, chosenNrOfRooms, chosenLivingArea, chosenPrice, chosenFloor);
                                }
                                else
                                {
                                    MessageBox.Show("Apartments legal form can only be rental or condominium");
                                    return;
                                }
                            }
                            break;
                    }
                    if (chosenEstateType != TypeOfEstate.Apartment)
                    {
                        if (!float.TryParse(tbPlotSize.Text.Trim(), out chosenPlotSize))
                        {
                            MessageBox.Show("Plot size must be a numerical value");
                            return;
                        }
                        else
                        {
                            estate.PlotSize = chosenPlotSize;
                        }
                    }
                    if(estate != null)
                    {
                        estates.Add(estate);
                        UpdateEstateListBox();
                    }
                    ResetFields();
                }
            }
        }

        /// <summary>
        /// Check if all textboxes within a panel is filled
        /// </summary>
        /// <param name="panel">The panel that has the textboxes within</param>
        /// <returns>True if all fields are filled</returns>
        private bool CheckFilledTextBoxes(Panel panel)
        {
            foreach (Control child in panel.Controls)
            {
                if (child is TextBox && child.Visible)
                {
                    if (string.IsNullOrEmpty(child.Text.Trim()))
                    {
                        MessageBox.Show("All fields must be filled");
                        return false;
                    }
                }
            }
            return true;
        }

        /// <summary>
        /// Creates an adress object from the input in the adress groupbox
        /// </summary>
        /// <returns></returns>
        private Adress CreateAdress()
        {
            Countries selectedCountry;
            Enum.TryParse<Countries>(cbCountry.SelectedValue.ToString(), out selectedCountry);
            Adress adress = new Adress(tbStreet.Text, tbZipCode.Text, tbCity.Text, selectedCountry);

            return adress;
        }

        /// <summary>
        /// Check if legal form is chosen and sets choseLegalForm to the chosen legal form
        /// </summary>
        /// <param name="legalForm"></param>
        /// <returns></returns>
        private bool CheckLegalForm(ref LegalForm legalForm)
        {
            RadioButton checkedButton = panelRegister.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            if (checkedButton != null)
            {
                if (checkedButton.Text == "Rental")
                {
                    legalForm = LegalForm.LegalRental;
                }
                else if (checkedButton.Text == "Condominium")
                {
                    legalForm = LegalForm.LegalCondominium;
                }
                else
                {
                    legalForm = LegalForm.LegalOwnership;
                }
            }
            else
            {
                MessageBox.Show("Legal form must be chosen");
                return false;
            }
            return true;
        }
        /// <summary>
        /// Reset all input fields in the form
        /// </summary>
        private void ResetFields()
        {
            foreach (Control ctr in panelRegister.Controls)
            {
                if (ctr is TextBox)
                {
                    ctr.Text = "";
                }
                else if (ctr is RadioButton)
                {
                    ((RadioButton)ctr).Checked = false;
                }
            }
            foreach (Control ctr in panelAdress.Controls)
            {
                if (ctr is TextBox)
                {
                    ctr.Text = "";
                }
                else if (ctr is ComboBox)
                {
                    ((ComboBox)ctr).SelectedIndex = -1;
                }
            }
            cbTypes.SelectedIndex = -1;
            panelRegister.Visible = false;
            panelAdress.Visible = false;
        }

        /// <summary>
        /// Update the listbox of estates
        /// </summary>
        private void UpdateEstateListBox()
        {
            lbEstates.Items.Clear();
            foreach(Estate estate in estates)
            {
                lbEstates.Items.Add(estate);
            }
        }

        private void lbEstates_SelectedIndexChanged(object sender, EventArgs e)
        {
            //tbInfo.Font = new Font(tbInfo.Font, FontStyle.Bold);
            //tbInfo.Text = estates[lbEstates.SelectedIndex].ToString();
            //tbInfo.Font = new Font(tbInfo.Font, FontStyle.Regular);
            //tbInfo.Text += estates[lbEstates.SelectedIndex].ToString();

            //var sb = new StringBuilder();
            //sb.Append(@"{\rtf1\ansi");
            //sb.Append(@"\b \fs24");
            //sb.Append(estates[lbEstates.SelectedIndex].Adress.Street);
            //sb.Append(@" \b0 \fs18");
            //sb.Append(@" \line ");
            //sb.Append(estates[lbEstates.SelectedIndex].Adress.ZipCode);
            //sb.Append(", ");
            //sb.Append(estates[lbEstates.SelectedIndex].Adress.City);
            //sb.Append(", ");
            //sb.Append(estates[lbEstates.SelectedIndex].Adress.Country);
            //sb.Append(@" \line \line");
            //sb.Append(@"\b ");
            //sb.Append(estates[lbEstates.SelectedIndex].Price + " kr");
            //sb.Append(@"\b0 ");
            //sb.Append(@" \line \line ");
            //sb.Append(@"}");

            //rtbInfo.Rtf = sb.ToString();

            rtbInfo.Rtf = estates[lbEstates.SelectedIndex].ShowInfo();
        }
    }
}
