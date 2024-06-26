﻿using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HotelManagement
{
    public partial class RoomForm : Form
    {
        private IStrategy<Room> RoomStrategy = new RoomStrategy();
        private List<Room> rooms = new List<Room>();
        public RoomForm(List<Room> rooms)
        {
            this.rooms = rooms;

            InitializeComponent();
            addButton.Click += AddRoom;
        }

        private void AddRoom(object? sender, EventArgs e)
        {
            string id = Utils.generateRandomId(5, "Room");
            string name = nameInput.Text;
            float chargeFee = (float)chargeFeeInput.Value;
            Room newRoom = new Room(id, name, chargeFee);

            RoomStrategy.Insert(newRoom);

            // Update list and DataGirdView
            rooms.Add(newRoom);
            RoomDataGridViewFormat(newRoom);

            MainApplication.roomEvent.Notify("build", rooms);

            MessageBox.Show("You have successfully inserted " + name, "Room Insertion", MessageBoxButtons.OK);
        }

        private void InitialLoad(object sender, EventArgs e)
        {
            rooms.ForEach(room =>
            {
                RoomDataGridViewFormat(room);
            });
        }

        private void RoomDataGridViewFormat(Room room)
        {
            DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
            row.Cells[0].Value = room.Id.ToString();
            row.Cells[1].Value = room.Name;
            row.Cells[2].Value = room.Charge_Fee.ToString();
            dataGridView1.Rows.Add(row);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var selectedRow = dataGridView1.CurrentRow;
            if (selectedRow != null && selectedRow.Cells.Count > 2)
            {
                string roomId;
                if (!selectedRow.Cells[0].Value.ToString().IsNullOrEmpty())
                {
                    roomId = selectedRow.Cells[0].Value.ToString();
                    var findedRoom = rooms.Find(x => x.Id == roomId);
                    rooms.Remove(findedRoom);
                    dataGridView1.Rows.Remove(selectedRow);
                    RoomStrategy.Delete(roomId);
                }
            }
        }
    }
}
