 //Timer 1 milisaniyede bir calışıyor
 
 private void timer1_Tick(object sender, EventArgs e)
        {
            if (label1.Left < -label1.Width)
            {
                label1.Left = 600;
            }
            else
            {
                label1.Left -= 3;
            }
        }
