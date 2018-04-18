 //Timer 1 milisaniyede bir calışıyor
 
 private void timer1_Tick(object sender, EventArgs e)
        {
            if (label1.Left < -label1.Width)//kayacagı boyut
            {
                label1.Left = 600;//Tekrar başlayacagı konum
            }
            else
            {
                label1.Left -= 3;//1 ms hareket ne kadar
            }
        }


