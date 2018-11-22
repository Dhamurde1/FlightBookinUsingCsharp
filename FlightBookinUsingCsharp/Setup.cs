using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TicketBooking
{
    class Setup
    {
        static void Main(string[] args)
        {

            TicketBooking tic = new TicketBooking();


           
            
            tic.OpenBrowser();

            tic.Login();

            tic.EnterDetails();
            
         
            tic.TearDown();




        }

    }
}
