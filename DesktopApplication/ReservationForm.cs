using System;
using Data;
using Business;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApplication
{
    public partial class DesktopApplicationForm : Form
    {

        List<Reservation> reservations;

        public DesktopApplicationForm()
        {
            InitializeComponent();
            reservations = new List<Reservation>();
            ReservationDateTimePicker.Format = DateTimePickerFormat.Custom;
            ReservationDateTimePicker.CustomFormat = "dd/MM/yyyy - hh:mm tt";
            SaleChannelComboBox.Items.Add("Sitio Web");
            SaleChannelComboBox.Items.Add("Teléfono");
            SaleChannelComboBox.Items.Add("En persona");
            SaleChannelComboBox.SelectedIndex = 1;
            ReservationDataGridView.MultiSelect = false;
            RetrieveAllReservations();
        }

        private void ReservationObtainButton_Click(object sender, EventArgs e)
        {
            RetrieveAllReservations();
        }

        private void AddWebReservations(List<Reservation> webReservations)
        {
            using (ReservationRepository reservationRepo = new ReservationRepository())
            {
                foreach (Reservation r in webReservations)
                {
                    //MessageBox.Show("Agregué: " + r.ToString());
                    reservationRepo.InsertReservation(r);
                }
            }

        }

        private void RetrieveAllReservations()
        {
            try
            {
                using (ReservationRepository repository = new ReservationRepository())
                {

                    List<Reservation> webReservations;
                    using (ReservationRetrieveService.ReservationServiceClient service = new ReservationRetrieveService.ReservationServiceClient())
                    {
                        webReservations = service.RequestReservationRetrieval().ToList();

                        if (webReservations.Count > 0)
                            AddWebReservations(webReservations);
                    }

                    reservations = repository.ObtainReservations().OrderBy(r => r.Date).ToList();
                    ReservationDataGridView.DataSource = reservations;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GuestsAmountTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void GuestsAmountLabel_Click(object sender, EventArgs e)
        {

        }

        private void ApplicationExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DesktopApplicationForm_Load(object sender, EventArgs e)
        {
            
        }

        private void ReservationCreateButton_Click(object sender, EventArgs e)
        {
            ReservationDateTimePicker.Value = DateTime.Now;
            ReservationCreateButton.Enabled = false;
            ReservationModifyButton.Enabled = false;
            ReservationCommitButton.Text = "Crear Reserva";
            ReservationCreationComponentsVisibility(true);
        }

        private void ReservationModifyButton_Click(object sender, EventArgs e)
        {
            if (ReservationDataGridView.SelectedRows.Count > 0)
            {
                // Visibility settings
                ReservationDateTimePicker.Value = DateTime.Now;
                ReservationCreateButton.Enabled = false;
                ReservationModifyButton.Enabled = false;
                ReservationCommitButton.Text = "Modificar Reserva";
                ReservationCreationComponentsVisibility(true);

                Reservation reservation;

                // Retrieve the row in the database.
                using (ReservationRepository repository = new ReservationRepository())
                {
                    reservation = repository.GetById(RetrieveCurrentIdSelection());
                }

                // Edit the textboxes to display current state of row.
                ReservationDateTimePicker.Value = reservation.Date;
                TableNumberTextBox.Value = reservation.TableNumber;
                FirstNameTextBox.Text = reservation.FirstName;
                LastNameTextBox.Text = reservation.LastName;
                ObservationsTextBox.Text = reservation.Observations;
                PhoneNumberTextBox.Text = reservation.PhoneNumber;
                EMailTextBox.Text = reservation.EMail;
                GuestsAmountTextBox.Value = reservation.GuestsAmount;
                SaleChannelComboBox.Enabled = false;
            }
            else
            {
                MessageBox.Show("Debe elegir una celda para poder modificarla.");
            }

        }

        private void ReservationDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void ReservationCommitButton_Click(object sender, EventArgs e)
        {
            ReservationCreateButton.Enabled = true;
            ReservationModifyButton.Enabled = true;

            if(ValidateReservationInputs())
            {
                Reservation reservation = new Reservation(0, 
                                                          ReservationDateTimePicker.Value, 
                                                          (int)GuestsAmountTextBox.Value, 
                                                          ObservationsTextBox.Text, 
                                                          SaleChannelComboBox.SelectedItem.ToString(), 
                                                          FirstNameTextBox.Text, 
                                                          LastNameTextBox.Text, 
                                                          PhoneNumberTextBox.Text, 
                                                          EMailTextBox.Text,
                                                          (int)TableNumberTextBox.Value);

                Validator validate = new Validator();

                if (validate.IsReservationUnique(reservation, reservations))
                {
                    if (ReservationCommitButton.Text == "Crear Reserva")
                    {

                        using (ReservationRepository repository = new ReservationRepository())
                        {
                            repository.InsertReservation(reservation);
                            MessageBox.Show("Reserva creada exitosamente.");
                            ReservationDataGridView.DataSource = repository.ObtainReservations();
                        }

                    }
                    else if (ReservationCommitButton.Text == "Modificar Reserva")
                    {
                        reservation.ReservationId = RetrieveCurrentIdSelection();

                        using (ReservationRepository repository = new ReservationRepository())
                        {
                            repository.UpdateReservation(reservation);
                            MessageBox.Show("Reserva modificada exitosamente.");
                            RetrieveAllReservations();
                        }

                    }

                    SaleChannelComboBox.Enabled = true;
                    ReservationCreationComponentsVisibility(false);
                    ClearReservationInputs();
                }
                else
                {
                    MessageBox.Show("El horario y mesa de la reserva ingresada están ambos ocupados.");
                }

            }
        }

        private void ReservationCreationComponentsVisibility (bool visibility)
        { 
            if(visibility)
            {
                // Make labels visible
                ReservationDateTimeLabel.Show();
                TableNumberLabel.Show();
                FirstNameLabel.Show();
                LastNameLabel.Show();
                ObservationsLabel.Show();
                PhoneNumberLabel.Show();
                EMailLabel.Show();
                GuestsAmountLabel.Show();
                SaleChannelLabel.Show();

                // Make usable componentes visible
                ReservationCancelButton.Show();
                ReservationDateTimePicker.Show();
                TableNumberTextBox.Show();
                FirstNameTextBox.Show();
                LastNameTextBox.Show();
                ObservationsTextBox.Show();
                PhoneNumberTextBox.Show();
                EMailTextBox.Show();
                GuestsAmountTextBox.Show();
                ReservationCommitButton.Show();
                SaleChannelComboBox.Show();
            }
            else
            {
                // Make labels invisible
                ReservationDateTimeLabel.Hide();
                TableNumberLabel.Hide();
                FirstNameLabel.Hide();
                LastNameLabel.Hide();
                ObservationsLabel.Hide();
                PhoneNumberLabel.Hide();
                EMailLabel.Hide();
                GuestsAmountLabel.Hide();
                SaleChannelLabel.Hide();

                // Make usable componentes invisible
                ReservationCancelButton.Hide();
                ReservationDateTimePicker.Hide();
                TableNumberTextBox.Hide();
                FirstNameTextBox.Hide();
                LastNameTextBox.Hide();
                ObservationsTextBox.Hide();
                PhoneNumberTextBox.Hide();
                EMailTextBox.Hide();
                GuestsAmountTextBox.Hide();
                ReservationCommitButton.Hide();
                SaleChannelComboBox.Hide();

                // Error Providers

                DateErrorProvider.Clear();
                FirstNameErrorProvider.Clear();
                LastNameErrorProvider.Clear();
                PhoneNumberErrorProvider.Clear();
                DateErrorProvider.Clear();
                EMailErrorProvider.Clear();

            }
        }

        private void ClearReservationInputs()
        {
            ReservationDateTimePicker.Value = DateTime.Now;
            TableNumberTextBox.Value = 1;
            FirstNameTextBox.Clear();
            LastNameTextBox.Clear();
            ObservationsTextBox.Clear();
            PhoneNumberTextBox.Clear();
            EMailTextBox.Clear();
            GuestsAmountTextBox.Value = 1;
            ReservationCommitButton.Text = "";
        }

        private bool ValidateReservationInputs()
        {
            if(ReservationDateTimePicker.Value >= DateTime.Now && !string.IsNullOrWhiteSpace(FirstNameTextBox.Text) && !string.IsNullOrWhiteSpace(LastNameTextBox.Text)
                && !string.IsNullOrWhiteSpace(PhoneNumberTextBox.Text) && !string.IsNullOrWhiteSpace(EMailTextBox.Text))
            {
                return true;
            }
            else
            {

                if (ReservationDateTimePicker.Value < DateTime.Now)
                    DateErrorProvider.SetError(ReservationDateTimePicker, "Debe elegir una hora mayor a la actual.");
                else
                    DateErrorProvider.Clear();

                if (string.IsNullOrWhiteSpace(FirstNameTextBox.Text))
                    FirstNameErrorProvider.SetError(FirstNameTextBox, "Debe ingresar un nombre.");
                else
                    FirstNameErrorProvider.Clear();

                if (string.IsNullOrWhiteSpace(LastNameTextBox.Text))
                    LastNameErrorProvider.SetError(LastNameTextBox, "Debe ingresar un apellido.");
                else
                    LastNameErrorProvider.Clear();

                if (string.IsNullOrWhiteSpace(PhoneNumberTextBox.Text))
                    PhoneNumberErrorProvider.SetError(PhoneNumberTextBox, "Debe ingresar un número de teléfono válido.");
                else
                    PhoneNumberErrorProvider.Clear();

                if (string.IsNullOrWhiteSpace(EMailTextBox.Text))
                    EMailErrorProvider.SetError(EMailTextBox, "Debe ingresar una dirección de correo electrónico válida.");
                else
                    EMailErrorProvider.Clear();

                return false;

            }
        }

        private void ReservationCancelButton_Click(object sender, EventArgs e)
        {
            ReservationCreationComponentsVisibility(false);
            ReservationCancelButton.Hide();
            ClearReservationInputs();
            ReservationCreateButton.Enabled = true;
            ReservationModifyButton.Enabled = true;
        }

        private void ReservationDeleteButton_Click(object sender, EventArgs e)
        {
            Reservation reservation;

            if (ReservationDataGridView.SelectedRows.Count > 0)
            {
                using (ReservationRepository repository = new ReservationRepository())
                {
                    reservation = repository.GetById(RetrieveCurrentIdSelection());
                    repository.DeleteReservation(reservation);
                    MessageBox.Show("Reserva eliminada exitosamente");
                    ReservationDataGridView.DataSource = repository.ObtainReservations();
                }
            }
            else
            {
                MessageBox.Show("Debe elegir una fila a eliminar.");
            }
        }

        private int RetrieveCurrentIdSelection()
        {
            return (int)ReservationDataGridView[0, ReservationDataGridView.SelectedRows[0].Index].Value;
        }

        private void ReservationViewObservation_Click(object sender, EventArgs e)
        {
            if(ReservationDataGridView.SelectedRows.Count > 0)
            {
                MessageBox.Show(ReservationDataGridView[3, ReservationDataGridView.SelectedRows[0].Index].Value.ToString());
            }
            else
            {
                MessageBox.Show("Debe elegir una reserva cuya observación se mostrará.");
            }
        }
    }
}
