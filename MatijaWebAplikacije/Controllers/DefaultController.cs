using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MatijaWebAplikacije.Controllers
{
    public class DefaultController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }

        //app za potrosnju
        public ViewResult Potrosnja()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Potrosnja(int? l, int? km)
        {
            if (l != null && km != null)
            {
                double? izracun = (double)l / km * 100;
                Convert.ToString(izracun);
                ViewBag.izracun = String.Format("{0:0.00}", izracun) + " L";
                return View();
            }
            else ViewBag.greska = "Greška :(, unesi podatke!"; 
                    return View();
          
           
        }

        //app za kw-->ks
        public ViewResult KwKs()
        {
            return View();
        }
        [HttpPost]
        public ViewResult KwKs(int? kw)
        {
            if (kw != null)
            {
                double? izracun = (double)kw * 1.36;
                Convert.ToString(izracun);
                ViewBag.izracun = String.Format("{0:0.00}", izracun) + " KS";
                return View();
            }
            else ViewBag.greska = "Greška :(, unesi podatke!";
            return View();
        }

        //app za ks-->kw
        public ViewResult KsKw()
        {
            return View();
        }
        [HttpPost]
        public ViewResult KsKw(int? ks)
        {
            if (ks != null)
            {
                double? izracun = (double)ks * 0.735499;
                Convert.ToString(izracun);
                ViewBag.izracun = String.Format("{0:0.00}", izracun) + " KW";
                return View();
            }
            else ViewBag.greska = "Greška :(, unesi podatke!";
            return View();
        }

        //app za eur-->hrk
        public ViewResult EurHrk()
        {
            return View();
        }
        [HttpPost]
        public ViewResult EurHrk(double? eur)
        {
            if (eur != null)
            {
                double? izracun = eur * 7.5;
                Convert.ToString(izracun);
                ViewBag.izracun = String.Format("{0:0.00}", izracun) + " KN";
                return View();
            }
            else ViewBag.greska = "Greška :(, unesi podatke!";
            return View();
        }

        //app za C --> F
        public ViewResult Cf()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Cf(double? c)
        {
            if (c != null && c != 0)
            {
                double? izracun = ((9.0 / 5.0) * c) + 32;
                Convert.ToString(izracun);
                ViewBag.izracun = String.Format("{0:0.00}", izracun) + " F°";
                return View();
            }
            else if (c == 0)
            {
                ViewBag.nula = "32 F°";
            }
            else ViewBag.greska = "Greška, unesi podatke!";
            return View();
        }

        //app za F --> C
        public ViewResult Fc()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Fc(double? f)
        {
            if (f != null && f != 0)
            {
                double? izracun = (double)5 / 9 * (f - 32);
                Convert.ToString(izracun);
                ViewBag.izracun = String.Format("{0:0.00}", izracun) + " C°";
                return View();
            }
            else if (f == 0)
            {
                ViewBag.nula = "-17.77 C°";
            }
            else ViewBag.greska = "Greška, unesi podatke!";
            return View();
        }

        //kalkulator
        public ViewResult Kalkulator()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Kalkulator(double? broj1, double? broj2, string operacija)
        {
            double? rezultat = 0;
            if (broj1 != null && broj2 != null)
            {
                if(operacija == "+")
                {
                    rezultat = broj1 + broj2;
                    Convert.ToString(rezultat);
                    ViewBag.rezultat = "Rezultat: " + String.Format("{0:0.00}", rezultat);
                    return View();
                }

                else if (operacija == "-")
                {
                    rezultat = broj1 - broj2;
                    Convert.ToString(rezultat);
                    ViewBag.rezultat = "Rezultat: " + String.Format("{0:0.00}", rezultat);
                    return View();
                }

                else if (operacija == "*")
                {
                    rezultat = broj1 * broj2;
                    Convert.ToString(rezultat);
                    ViewBag.rezultat = "Rezultat: " + String.Format("{0:0.00}", rezultat);
                    return View();
                }

                else if (operacija == "/")
                {
                    rezultat = broj1 / broj2;
                    Convert.ToString(rezultat);
                    ViewBag.rezultat = "Rezultat: " + String.Format("{0:0.00}", rezultat);
                    return View();
                }
            }
            else ViewBag.greska = "Greška, unesi brojeve!";
            return View();
        }
    }
}