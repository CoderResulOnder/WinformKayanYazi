//Bu işlem web te 
//<marquee align="middle" scrollamount="1" height="30" width="100%" direction="down"scrolldelay="1">YAZINIZ BURAYA</marquee>
//<marquee scrollamount="10" behavior="left" style="margin-top:2%">                                            
                                            //<img style="width:150px;height:110px" src="/img1.jpg">
                                            //<img style="width:150px;height:110px" src="/img2.jpg">
                                            //<img style="width:150px;height:110px" src="/img3.jpg">
                                            //<img style="width:150px;height:110px" src="/img4.jpg">
                                            //<img style="width:150px;height:110px" src="/img5.jpg">
                                            //</marquee>

//ile yapılırken winformda 
//Timer 1 milisaniyede bir calışıyor
 
 private void timer1_Tick(object sender, EventArgs e)
        {
  //budara label yerine buton panel vb neslerer referans verilerek nesnelerde kaydırılabilir
  
            if (label1.Left < -label1.Width)//kayacagı boyut
            {
                label1.Left = 600;//Tekrar başlayacagı konum
            }
            else
            {
                label1.Left -= 3;//1 ms hareket ne kadar
            }
        }


