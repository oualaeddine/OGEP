using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Calendar;

namespace OGEP.Planing
{
    public partial class PlaningView : MetroFramework.Forms.MetroForm
    {
        private List<CalendarItem> loadedItems=new List<CalendarItem>();

        public PlaningView()
        {
            InitializeComponent();
        }

        private void PlaningView_Load(object sender, EventArgs e)
        {
            //  getPlaning();
            calendar1.ViewStart = DateTime.Now;
            calendar1.ViewEnd = DateTime.Now.AddDays(6);
        }
        
        private void getPlaning()
        {

            ItemInfo item = new ItemInfo(DateTime.Now, DateTime.Now.AddHours(4), "Groupe A Math | Brihmat", Color.BlueViolet);
            CalendarItem cal = new CalendarItem(calendar1, item.StartTime, item.EndTime, item.Text);

            if (!(item.R == 0 && item.G == 0 && item.B == 0))
            {
                cal.ApplyColor(Color.FromArgb(item.A, item.R, item.G, item.B));
            }

            calendar1.Items.Add(cal);

            ItemInfo item2 = new ItemInfo(DateTime.Now, DateTime.Now.AddHours(4), "Groupe A physique | boukhemiss", Color.OrangeRed);
            CalendarItem cal2 = new CalendarItem(calendar1, item2.StartTime, item2.EndTime, item2.Text);

            if (!(item2.R == 0 && item2.G == 0 && item2.B == 0))
            {
                cal2.ApplyColor(Color.FromArgb(item2.A, item2.R, item2.G, item2.B));
            }

            calendar1.Items.Add(cal2);
        }

        private void calendar1_LoadItems_1(object sender, CalendarLoadEventArgs e)
        {
            /*   //Load items whose date range intersects e.DateStart and e.DateEnd
               foreach (CalendarItem item in loadedItems)
               {
                   calendar1.Items.Add(item);
               }

               //Or even better....
               calendar1.Items.AddRange(loadedItems);*/
            getPlaning();
        }
    }
}
