﻿using System;
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
        private PayStation PayStation;
        private Ticket ticket;
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
            ticket = new Ticket();
            PayStation = new PayStation();

            ticketMachine.AssignCarPark(carPark);
            ticketValidator.AssignCarPark(carPark);

            /////////////////////////////////////////

            btnCarArrivesAtEntrance.Visible = true;
            btnDriverPressesForTicket.Visible = false;
            btnCarEntersCarPark.Visible = false;
            btnCarArrivesAtExit.Visible = false;
            btnDriverEntersTicket.Visible = false;
            btnCarExitsCarPark.Visible = false;
            btnDriverPaysForTicket.Visible = false;

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

            if (carPark.IsFull() == false)
            {
                btnCarArrivesAtEntrance.Visible = true;
                if (String.IsNullOrEmpty((string)lblTicketValidator.Text))
                {
                    btnCarArrivesAtExit.Visible = true;
                }
            }
            else btnCarArrivesAtEntrance.Visible = false;
            UpdateDisplay();
        }

        private void CarArrivesAtExit(object sender, EventArgs e)
        {
            exitSensor.CarDetected();
            btnCarArrivesAtExit.Visible = false;
            btnDriverPaysForTicket.Visible = true;
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

        /*private void DriverPaysForTicket(object sender, EventArgs e)
        {
            lblTicketValidator.Text = ticketValidator.GetMessage();
            lstActiveTickets.Items.Add("#" + PayStation.TicketPayment(activeTickets) + ":          " + ticket.SetPaid());
            activeTickets.RemoveTicket();
            lstActiveTickets.Items.RemoveAt(0);
            btnDriverPaysForTicket.Visible = false;
            btnDriverEntersTicket.Visible = true;
            UpdateDisplay();
        }*/

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
            lstActiveTickets.Items.Clear();
            List<Ticket> tickets = activeTickets.GetTickets();
            int currentTicket = 0;
            foreach (Ticket ticket in tickets)
            {
                string ticketStat = "#" + ticket.GetHashCode().ToString() + ": " + ticket.IsPaid().ToString();
                lstActiveTickets.Items.Add(ticketStat);
                currentTicket += 1;
            }
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void SimulatorInterface_Load(object sender, EventArgs e)
        {

        }

        private void btnDriverPaysForTicket_Click_1(object sender, EventArgs e)
        {
            lblTicketValidator.Text = ticketValidator.GetMessage();
            lstActiveTickets.Items.Add("#" + PayStation.TicketPayment(activeTickets) + ": " + ticket.SetPaid().ToString());;
            lstActiveTickets.Items.RemoveAt(0);
            btnDriverPaysForTicket.Visible = false;
            btnDriverEntersTicket.Visible = true;
        }
    }
}
