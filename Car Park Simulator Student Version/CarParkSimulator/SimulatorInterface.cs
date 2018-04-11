using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CarParkSimulator
{
    public partial class SimulatorInterface : Form
    {
        // Attributes ///        
        private TicketMachine ticketMachine;
        private ActiveTickets activeTickets;
        private TicketValidator ticketValidator;
        private Barrier entryBarrier;
        private Barrier exitBarrier;
        private FullSign fullSign;
        private CarPark carPark;
        private EntrySensor entrySensor;
        private ExitSensor exitSensor;
        /////////////////


        // Constructor //
        public SimulatorInterface()
        {
            InitializeComponent();
        }
        /////////////////


        // Operations ///
        private void ResetSystem(object sender, EventArgs e)
        {
            // STUDENTS:
            ///// Class contructors are not defined so there will be errors
            ///// This code is correct for the basic version though
            activeTickets = new ActiveTickets();
            ticketMachine = new TicketMachine(activeTickets);
            ticketValidator = new TicketValidator(activeTickets);
            entryBarrier = new Barrier();
            exitBarrier = new Barrier();
            fullSign = new FullSign();
            carPark = new CarPark(ticketMachine, ticketValidator, fullSign, entryBarrier, exitBarrier);
            entrySensor = new EntrySensor(carPark);
            exitSensor = new ExitSensor(carPark);

            ticketMachine.AssignCarPark(carPark);
            ticketValidator.AssignCarPark(carPark);

            /////////////////////////////////////////

            btnCarArrivesAtEntrance.Visible = true;
            btnDriverPressesForTicket.Visible = false;
            btnCarEntersCarPark.Visible = false;
            btnCarArrivesAtExit.Visible = false;
            btnDriverEntersTicket.Visible = false;
            btnCarExitsCarPark.Visible = false;

            UpdateDisplay();
        }

        private void CarArrivesAtEntrance(object sender, EventArgs e)
        {
            entrySensor.CarDetected();
            btnCarArrivesAtEntrance.Visible = false;
            btnDriverPressesForTicket.Visible = true;
            UpdateDisplay();
        }

        private void DriverPressesForTicket(object sender, EventArgs e)
        {
            ticketMachine.PrintTicket();
            entryBarrier.Raise();
            btnDriverPressesForTicket.Visible = false;
            btnCarEntersCarPark.Visible = true;
            UpdateDisplay();
        }

        private void CarEntersCarPark(object sender, EventArgs e)
        {
            entrySensor.CarLeftSensor();
            btnCarEntersCarPark.Visible = false;
            btnCarArrivesAtExit.Visible = true;

            if (carPark.IsFull() == false)
            {
                btnCarArrivesAtEntrance.Visible = true;
            }
            else btnCarArrivesAtEntrance.Visible = false;
            UpdateDisplay();
        }

        private void CarArrivesAtExit(object sender, EventArgs e)
        {
            exitSensor.CarDetected();
            btnCarArrivesAtExit.Visible = false;
            btnDriverEntersTicket.Visible = true;
            UpdateDisplay();
        }

        private void DriverEntersTicket(object sender, EventArgs e)
        {
            ticketValidator.TicketEntered();
            exitBarrier.Raise();
            btnDriverEntersTicket.Visible = false;
            btnCarExitsCarPark.Visible = true;
            UpdateDisplay();

        }

        private void CarExitsCarPark(object sender, EventArgs e)
        {
            exitSensor.CarLeftSensor();
            btnCarExitsCarPark.Visible = false;
            btnCarArrivesAtExit.Visible = true;
            if (carPark.IsEmpty() == false)
            {
                if (String.IsNullOrEmpty((string)lblTicketMachine.Text))
                {
                    btnCarArrivesAtEntrance.Visible = true;
                }
            }
               else btnCarArrivesAtExit.Visible = false;
            UpdateDisplay();
        }

        private void UpdateDisplay()
        {
            lblTicketMachine.Text = ticketMachine.GetMessage();
            lblTicketValidator.Text = ticketValidator.GetMessage();
            lblEntrySensor.Text = Convert.ToString(entrySensor.IsCarOnSensor());
            lblExitSensor.Text = Convert.ToString(exitSensor.IsCarOnSensor());
            lblSpaces.Text = Convert.ToString(carPark.GetCurrentSpaces());
            lblFullSign.Text = Convert.ToString(fullSign.IsLit());          
            lblEntryBarrier.Text = Convert.ToString(entryBarrier.IsLifted());
            lblExitBarrier.Text = Convert.ToString(exitBarrier.IsLifted());
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void SimulatorInterface_Load(object sender, EventArgs e)
        {

        }
    }
}
