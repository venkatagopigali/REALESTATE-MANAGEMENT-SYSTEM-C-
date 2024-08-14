﻿using System.Net;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Xml.Linq;

class seller
{
    public static List<string> nna = new List<string>();
    public static List<string> pph = new List<string>();
    public static List<double> sqft = new List<double>();
    public static List<int> bed = new List<int>();
    public static List<int> bath = new List<int>();
    public static List<int> hal = new List<int>();
    public static List<int> kitchen = new List<int>();
    public static List<int> ball = new List<int>();
    public static List<double> se = new List<double>();
    public static List<double> ac = new List<double>();
    public static List<double> paac = new List<double>();
    public static List<string> bna = new List<string>();
    public static List<string> bp = new List<string>();
    public void sell()
    {

        int ms;
        string cn, cph, ce,na,p,email;
        Console.Clear();
        Console.WriteLine("****************************************SELLER DETAILS*************************************************\n");
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.Write("NAME          :");
        na = Console.ReadLine();
        nna.Add(na);
        Console.WriteLine();
        Console.Write("PHONE         :");
        p = Console.ReadLine();
        pph.Add(p);
        Console.WriteLine();
        Console.Write("E-MAIL        :");
        email = Console.ReadLine();
        Console.WriteLine();
        Console.Clear();
        Console.WriteLine("****************************************SELLER PORTAL*************************************************\n");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("PLEASE SELECT WHICH TYPE OF PROPERTY DO YOU WANT TO SELL:\n");
    Y2: Console.WriteLine("1.HOUSE \n\n2.LAND");
        ms = Convert.ToInt32(Console.ReadLine());
        if (ms == 1)
        {
            double hl, hw, cost, mc;
            int br, ba, hall, doc, buy, kit, bal;
            Console.Clear();
            P: Console.WriteLine("*********************************HOUSE MEDIATOR********************************************\n");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("PLEASE ENTER YOUR HOUSE DETAILS:");
            Console.WriteLine();
            Console.WriteLine("         HOUSE LAND DETAILS:              ");
            Console.Write("SQFT           :");
            hl = Convert.ToDouble(Console.ReadLine());
            sqft.Add(hl);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("          HOUSE DETAILS:                 ");
            Console.Write("BED ROOMS      :");
            br = Convert.ToInt32(Console.ReadLine());
            bed.Add(br);
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("BATH ROOMS     :");
            ba = Convert.ToInt32(Console.ReadLine());
            bath.Add(ba);
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("HALLS          :");
            hall = Convert.ToInt32(Console.ReadLine());
            hal.Add(hall);
            Console.WriteLine();
            Console.WriteLine();
        B: Console.WriteLine("KTCHEN         :");
            Console.WriteLine("1.OPEN KITCHEN\n2.CLOSED  KITCHEN");
            Console.WriteLine();
            kit = Convert.ToInt32(Console.ReadLine());
            kitchen.Add(kit);
            if (kit == 1)
            {
                Console.WriteLine("OPEN KITCHEN");
            }
            else if (kit == 2)
            {
                Console.WriteLine("CLOSED KITCHEN");
            }
            else
            {
                Console.WriteLine("ENTER VALID OPTION:");
                goto B;
            }
            Console.WriteLine();
            Console.Write("BALCONY        :");
            bal = Convert.ToInt32(Console.ReadLine());
            ball.Add(bal);
            Console.WriteLine();
            Console.Write("PLEASE MENTION YOUR SELLING PRICE     :");
            cost = Convert.ToDouble(Console.ReadLine());
            se.Add(cost);
            if (hl > 0 && br > 0 && ba > 0 && hall > 0 && kit > 0 && bal > 0)
            {
                Console.WriteLine("---------------THANK YOU-------------");
                Console.WriteLine();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
            X1: Console.WriteLine("DO YOU WANT TO PUSH THE DETAILS TO OUR MEDIATOR:\n\n1.YES\n\n2.NO");
                doc = Convert.ToInt32(Console.ReadLine());
                if (doc == 1)
                {
                    while (true)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("===========================WELCOME TO MEDIATOR PORTAL=======================================\n");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("            INTRESTED PERSONS CAN CONTACT US TO PURCHASE                    ");
                        Console.WriteLine("SQFT              :" + hl + "   sqft");
                        Console.WriteLine();
                        Console.WriteLine("BED ROOMS         :" + br);
                        Console.WriteLine();
                        Console.WriteLine("BATH ROOMS        :" + ba);
                        Console.WriteLine();
                        Console.WriteLine("HALLS             :" + hall);
                        Console.WriteLine();
                        Console.WriteLine("KITCHEN           :" + kit + " 1.OPEN KITCHEN\n2.CLOSED KITCHEN");
                        Console.WriteLine();
                        Console.WriteLine("BALCONEY          :" + bal);
                        Console.WriteLine();
                        mc = (cost / 100) * 10;
                        double total = cost + mc;
                        Console.WriteLine("SELLING PRICE IS  :" + total);
                    X: Console.WriteLine("1.YES\n\n2.NO\n");
                        buy = Convert.ToInt32(Console.ReadLine());
                        if (buy == 1)
                        {
                            string bn, bph, be;
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("--------------------BUYER DETAILS------------------\n");
                            Console.Write("YOUR NAME            :");
                            bn = Console.ReadLine();
                            bna.Add(bn);
                            Console.WriteLine();
                            Console.Write("YOUR PHONE NUMBER    :");
                            bph = Console.ReadLine();
                            bp.Add(bph);
                            Console.WriteLine();
                            Console.Write("YOUR E-Mail ID       :");
                            be = Console.ReadLine();
                            Console.WriteLine(); Console.WriteLine();
                            Console.WriteLine("          THANKYOU FOR SHOWING INTREST WE WILL CONTACT YOU VERY SOON           ");
                            break;
                        }
                        else if (buy == 2)
                        {
                            Console.WriteLine("-----------------THANK YOU FOR VISITING-----------------------");
                            goto X;
                        }
                        else
                        {
                            Console.WriteLine("please enter valid option:");
                            goto X;
                        }
                    }
                }
                else if (doc == 2)
                {
                    Console.WriteLine("THANKYOU FOR SHOWING INTREST::");

                }
                else
                {
                    Console.WriteLine("entre valid option:");
                    goto X1;
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("PLEASE MENTION CORRECT DETALIS");
                goto P;
            }
        }
        else if (ms == 2)
        {
            double a, pac;
            int doc;
            Console.Clear();
            Console.WriteLine("=======================SELLER PORTEL=======================================\n\n");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            j1: Console.WriteLine("----------------ENTER YOUR LAND DETAILS-----------------------\n\n");
            Console.Write("HOW MANY ACERS OF LAND DO YOU WANT TO SELL :");
            a = Convert.ToDouble(Console.ReadLine());
            ac.Add(a);
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("PER ACER COST               :");
            pac = Convert.ToDouble(Console.ReadLine());
            paac.Add(pac);
            Console.WriteLine();
            Console.WriteLine("THE TOTAL SELLING PRICE :" + (pac * a));
            Console.WriteLine(); Console.WriteLine();
            if (pac > 0 && a > 00)
            {
                Console.WriteLine("---------------THANK YOU -------------");
                Console.Clear();
            Y1: Console.WriteLine("DO YOU WANT TO PUSH THE DETAILS TO THE MEDIATOR:\n\n1.YES\n\n2.NO");
                doc = Convert.ToInt32(Console.ReadLine());
                if (doc == 1)
                {

                    while (true)
                    {
                        int buy;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("-----------------INTRESTED PERSONS CAN CONTACT US TO PURCHASE THIS LAND------------------\n");
                        Console.WriteLine();
                        Console.WriteLine("TOTAL ACERS ARE         :" + a);
                        Console.WriteLine();
                        Console.WriteLine("THE SELLING PRICE        :" + ((pac * a) + (((pac * a) / 100) * 10)));
                        Console.WriteLine();
                    Y: Console.WriteLine("1.YES\n\n2.NO\n");
                        buy = Convert.ToInt32(Console.ReadLine());
                        if (buy == 1)
                        {
                            string bn, bph, be;
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("--------------------PLEASE ENTER YOUR DETAILS------------------\n");
                            Console.WriteLine();
                            Console.Write("YOUR NAME            :");
                            bn = Console.ReadLine();
                            bna.Add(bn);
                            Console.WriteLine();
                            Console.Write("YOUR PHONE NUMBER    :");
                            bph = Console.ReadLine();
                            bp.Add(bph);
                            Console.WriteLine();
                            Console.Write("YOUR E-Mail ID       :");
                            be = Console.ReadLine();
                            Console.WriteLine(); Console.WriteLine();
                            Console.WriteLine("          THANKYOU WE WILL CONTACT YOU VERY SOON           ");
                            break;
                        }
                        else if (buy == 2)
                        {
                            Console.WriteLine("-----------------THANK YOU FOR VISITING-----------------------");
                            goto Y;
                        }
                        else
                        {
                            Console.WriteLine("plese entre valid option:");
                            goto Y;
                        }
                    }
                }
                else if (doc == 2)
                {
                    Console.WriteLine("----------------------THANKYOU FOR VISITING-----------------------");
                }
                else
                {
                    Console.WriteLine("please enter valid option;");
                    goto Y1;
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("PLEASE MENTION CORRECT DETAILS:");
                goto j1;
            }
        }
        else
        {
            Console.WriteLine("enter valid option");
            goto Y2;
        }
    }

}
class mediator : buyer
{
    public void display()
    {
        int ct1 = sqft.Count, ct2 = ac.Count ,ct3=nnna.Count;
        if (ct1 == 0 && ct2 == 0 && ct3 == 0)
        {
            Console.WriteLine("No properties are registered.Please register first");
        }
        else
        {
            for (int i = 0; i < ct1; i++)
            {
                Console.WriteLine("                     SELLER DETAILS");
                Console.WriteLine("****************************************************************");
                Console.WriteLine("****************************************************************");
                Console.WriteLine("\nName              :" + nna[i]);
                Console.WriteLine("\nPHONE             :" + pph[i]);
                Console.WriteLine("\n\n                 HOUSE DETAILS:");
                Console.WriteLine("****************************************************************");
                Console.WriteLine("\nTotal square feet : " + sqft[i]);
                Console.WriteLine("\nbed rooms         :" + bed[i]);
                Console.WriteLine("\nbath rooms        :" + bath[i]);
                Console.WriteLine("\nhalls             :" + hal[i]);
                Console.WriteLine("\nkitchen           :" + kitchen[i]);
                Console.WriteLine("\nbalconwy          :" + ball[i]);
                Console.WriteLine("\nselling price       :" + se[i]);
                Console.WriteLine("\n\n                BUYER DETAILS:");
                Console.WriteLine("****************************************************************");
                Console.WriteLine("\nName              :" + bna[i]);
                Console.WriteLine("\nPHONE             :" + bp[i]);
            }
            for (int i = 0; i < ct2; i++)
            {
                Console.WriteLine("                    SELLER DETAILS\n");
                Console.WriteLine("****************************************************************");
                Console.WriteLine("****************************************************************");
                Console.WriteLine("\nName              :" + nna[i]);
                Console.WriteLine("\nPHONE             :" + pph[i]);
                Console.WriteLine("\n\n                LAND DETAILS:");
                Console.WriteLine("****************************************************************");
                Console.WriteLine("\nacers             :" + ac[i]);
                Console.WriteLine("per acer price    :" + paac[i]);
                Console.WriteLine("\n\n                BUYER DETAILS:");
                Console.WriteLine("****************************************************************");
                Console.WriteLine("\nName              :" + bna[i]);
                Console.WriteLine("\nPHONE             :" + bp[i]);
            }
            for (int i = 0; i < ct3; i++)
            {
                Console.WriteLine("\n\n                BUYER DETAILS\n");
                Console.WriteLine("****************************************************************");
                Console.WriteLine("****************************************************************");
                Console.WriteLine("\nName              :" + nnna[i]);
                Console.WriteLine("\nPHONE             :" + ppph[i]);
            }
        }
    }

}
class buyer : seller
{
    public static List<string> nnna = new List<string>();
    public static List<string> ppph = new List<string>();
    public void buy()
    {
        int ms;
        string cn, cph, ce,na1,p,email;
        Console.Clear();
        Console.WriteLine("****************************************BUYER DETAILS*************************************************\n");
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.Write("NAME          :");
        na1 = Console.ReadLine();
        nnna.Add(na1);
        Console.WriteLine();
        Console.Write("PHONE         :");
        p = Console.ReadLine();
        ppph.Add(p);
        Console.WriteLine();
        Console.Write("E-MAIL        :");
        email = Console.ReadLine();
        Console.WriteLine();
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("***************************************BUYER*********************************************");
        Console.WriteLine();
        Console.WriteLine();
    Z: Console.WriteLine("PLEASE SELECT WHICH TYPE OF PROPERTY DO YOU WANT TO BUY:\n");
        Console.WriteLine("1.HOUSE\n\n2.LAND\n");
        ms = Convert.ToInt32(Console.ReadLine());
        if (ms == 1)
        {
            int sh;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.WriteLine("--------------------house mediator-----------------------\n\n");
        Z1: Console.WriteLine("DO YOU WANT HAVE A LOOK AT AVAILABLE HOUSE'S:[if you have certain specifications please click 2]   \n\n:");
            Console.WriteLine();
            Console.WriteLine("1.YES\n\n2.NO");
            sh = Convert.ToInt32(Console.ReadLine());
            if (sh == 1)
            {
                int buy;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("------------THE AVAILABLE HOUSES ARE-------------");
                Console.WriteLine("1.LAND(SQFT)            :1500\n  BED ROOMS             :3\n  BATH ROOMS            :2\n  HALLS                 :1\n  KITCHEN               :1\n  WITH BALCONEY\n *****THE PRICE      1100000/-  *****");
                Console.WriteLine();
                Thread.Sleep(1500);
                Console.WriteLine();
                Console.WriteLine("2.LAND(SQFT)            :1200\n  BED ROOMS             :2\n  BATH ROOMS            :2\n  HALLS                 :1\n  KITCHEN               :1\n *****THE PRICE      900000/-  *****");
                Console.WriteLine();
                Console.WriteLine();
                Thread.Sleep(1500);
                Console.WriteLine("3.LAND(SQFT)            :1800\n  BED ROOMS             :4\n  BATH ROOMS            :4\n  HALLS                 :2\n  KITCHEN               :1\n  WITH BALCONEY\n *****THE PRICE      2000000/-  *****");
                Console.WriteLine();
                Console.WriteLine();
                Thread.Sleep(1500);
                Console.WriteLine("4.LAND(SQFT)            :2500\n  BED ROOMS             :3\n  BATH ROOMS            :3\n  HALLS                 :1\n  KITCHEN               :1\n *****THE PRICE      710000/-  *****");
                Console.WriteLine();
                Console.WriteLine();
                Thread.Sleep(1500);
                Console.WriteLine("5.LAND(SQFT)            :2100\n  BED ROOMS             :3\n  BATH ROOMS            :3\n  HALLS                 :2\n  KITCHEN               :1\n  WITH BALCONEY\n *****THE PRICE      1500000/-  *****");
                Console.WriteLine();
                Console.WriteLine();
            Z2: Console.WriteLine("ARE YOU INTRESTED IN BUYING ANY OF THESE HOUSES :\n");
                Console.WriteLine("1.YES\n\n2.NO\n");
                buy = Convert.ToInt32(Console.ReadLine());
                if (buy == 1)
                {
                    int sltb;
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                Z3: Console.Write("WHICH HOUSE YOU WANT TO BUY        :");
                    sltb = Convert.ToInt32(Console.ReadLine());
                    if (sltb == 1)
                    {
                        Console.WriteLine("1.LAND(SQFT)            :1500\n  BED ROOMS             :3\n  BATH ROOMS            :2\n  HALLS                 :1\n  KITCHEN               :1\n  WITH BALCONEY\n *****THE PRICE      1100000/-  *****");
                        Console.WriteLine();
                        Console.WriteLine("********************THANKYOU FOR BUYING************************");
                    }
                    else if (sltb == 2)
                    {
                        Console.WriteLine("2.LAND(SQFT)            :1200\n  BED ROOMS             :2\n  BATH ROOMS            :2\n  HALLS                 :1\n  KITCHEN               :1\n *****THE PRICE      900000/-  *****");
                        Console.WriteLine();
                        Console.WriteLine("********************THANKYOU FOR BUYING************************");
                    }
                    else if (sltb == 3)
                    {
                        Console.WriteLine("3.LAND(SQFT)            :1800\n  BED ROOMS             :4\n  BATH ROOMS            :4\n  HALLS                 :2\n  KITCHEN               :1\n  WITH BALCONEY\n *****THE PRICE      2000000/-  *****");
                        Console.WriteLine();
                        Console.WriteLine("********************THANKYOU FOR BUYING************************");
                    }
                    else if (sltb == 4)
                    {
                        Console.WriteLine("4.LAND(SQFT)            :2500\n  BED ROOMS             :3\n  BATH ROOMS            :3\n  HALLS                 :1\n  KITCHEN               :1\n *****THE PRICE      710000/-  *****");
                        Console.WriteLine();
                        Console.WriteLine("********************THANKYOU FOR BUYING************************");
                    }
                    else if (sltb == 5)
                    {
                        Console.WriteLine("5.LAND(SQFT)            :2100\n  BED ROOMS             :3\n  BATH ROOMS            :3\n  HALLS                 :2\n  KITCHEN               :1\n  WITH BALCONEY\n *****THE PRICE      1500000/-  *****");
                        Console.WriteLine();
                        Console.WriteLine("********************THANKYOU FOR BUYING************************");
                    }
                    else
                    {
                        Console.WriteLine("ENTER VALID OPTION:");
                        goto Z3;
                    }
                }
                else if (buy == 2)
                {
                    int spe;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                Z5: Console.WriteLine("DO YOU HAVE ANY SPECIFICATIONS PLEASE MENTION HERE:\n");
                    Console.WriteLine("1.YES\n\n2.NO\n");
                    spe = Convert.ToInt32(Console.ReadLine());
                    if (spe == 1)
                    {
                        double hl, hw, cost;
                        int br, bt, hall, k, bal, sl;
                        V: Console.WriteLine("         HOUSE LAND DETAILS:              ");
                        Console.Write("SQFT           :");
                        hl = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("          HOUSE DETAILS:                 ");
                        Console.Write("BED ROOMS      :");
                        br = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.Write("BATH ROOMS     :");
                        bt = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.Write("HALL           :");
                        hall = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.Write("KITCHEN        :");
                        k = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.Write("BALCONEY       :");
                        bal = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine();
                        if (hl > 0 && br > 0 && bt > 0 && hall > 0 && k > 0 && bal > 0)
                        {
           
                            Console.WriteLine("        THANKYOU          ");
                            while (true)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("*****IS ANYONE INTRESTED IN SELLING THEIR HOUSE BASED ON THESE REQUIREMENTS*****\n\n");
                                Console.WriteLine("SQFT           :" + hl);
                                Console.WriteLine();
                                Console.WriteLine("BED ROOMS      :" + br);
                                Console.WriteLine();
                                Console.WriteLine("BATH ROOMS     :" + bt);
                                Console.WriteLine();
                                Console.WriteLine("HALL           :" + hall);
                                Console.WriteLine();
                                Console.WriteLine("KITCHEN        :" + k);
                                Console.WriteLine();
                                Console.WriteLine("BALCONEY       :" + bal);
                                Console.WriteLine();
                                Console.WriteLine();
                            Z4: Console.WriteLine("1.YES\n2.NO\n3.DOES NOT CONTAIN THE REQUAIREMENTS");
                                sl = Convert.ToInt32(Console.ReadLine());
                                if (sl == 1)
                                {
                                    int doc;
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    string bn, bph, be;
                                    Console.WriteLine("--------------------PLEASE ENTER YOUR DETAILS SIR------------------\n");
                                    Console.Write("YOUR NAME            :");
                                    bn = Console.ReadLine();
                                    Console.WriteLine();
                                    Console.Write("YOUR PHONE NUMBER    :");
                                    bph = Console.ReadLine();
                                    Console.WriteLine();
                                    Console.Write("YOUR E-Mail ID       :");
                                    be = Console.ReadLine();
                                    Console.WriteLine();
                                    Console.Write("THE HOUSE SELLING COST IS      :");
                                    cost = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine();
                                G: Console.WriteLine("DO YOU HAVE PROPER DOCUMENTS\n:");
                                    Console.Write("1.YES\n\n2.NO\n");
                                    doc = Convert.ToInt32(Console.ReadLine());
                                    if (doc == 1)
                                    {
                                        Console.WriteLine("++++++++++THANKYOU FOR SELLING++++++++++++++");
                                    }
                                    else if (doc == 2)
                                    {
                                        Console.WriteLine("!NOT ACCEPTED");
                                    }
                                    else
                                    {
                                        Console.WriteLine("entre valid option");
                                        goto G;
                                    }
                                    break;
                                }
                                else if (sl == 2)
                                {
                                    Console.WriteLine("*************THANKYOU FOR VISITING**************");
                                }
                                else if (sl == 3)
                                {
                                    Console.WriteLine("*************THANKYOU FOR VISITING**************");
                                }
                                else
                                {
                                    Console.WriteLine("enter valid option:");
                                    goto Z4;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Please mention correct details");
                            goto V;
                        }
                    }
                    else if (spe == 2)
                    {
                        Console.WriteLine("**********THANKYOU FOR VISITING*************");
                    }
                    else
                    {
                        Console.WriteLine("enter valid option");
                        goto Z5;
                    }
                }
                else
                {
                    Console.WriteLine("enter valid options:");
                    goto Z2;
                }
            }
            else if (sh == 2)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("mention your requirements:");
                int spe;
            Z7: Console.WriteLine("DO YOU HAVE ANY SPECIFICATIONS PLEASE MENTION HERE:\n");
                Console.WriteLine("1.YES\n\n2.NO\n");
                spe = Convert.ToInt32(Console.ReadLine());
                if (spe == 1)
                {
                    Console.Clear();
                    double hl, hw, cost;
                    int br, bt, hall, k, bal, sl;
                    F: Console.WriteLine("         HOUSE LAND DETAILS:              ");
                    Console.WriteLine(); Console.WriteLine();
                    Console.Write("SQFT           :");
                    hl = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(); Console.WriteLine();
                    Console.WriteLine("          HOUSE DETAILS:                 ");
                    Console.Write("BED ROOMS      :");
                    br = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(); Console.WriteLine();
                    Console.Write("BATH ROOMS     :");
                    bt = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(); Console.WriteLine();
                    Console.Write("HALL           :");
                    hall = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(); Console.WriteLine();
                    Console.Write("KITCHEN        :");
                    k = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(); Console.WriteLine();
                    Console.Write("BALCONEY       :");
                    bal = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(); Console.WriteLine();
                    if (hl > 0 && br > 0 && bt > 0 && hall > 0 && k > 0 && bal > 0)
                    {
                        while (true)
                        {
                            Console.WriteLine("        THANKYOU SIR          ");
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine("*****IS ANYONE INTRESTED TO SELL THEIR HOUSE BASED ON THESE REQUIREMENTS*****\n\n");
                            Console.WriteLine("SQFT           :" + hl);
                            Console.WriteLine();
                            Console.WriteLine("BED ROOMS      :" + br);
                            Console.WriteLine();
                            Console.WriteLine("BATH ROOMS     :" + bt);
                            Console.WriteLine();
                            Console.WriteLine("HALL           :" + hall);
                            Console.WriteLine();
                            Console.WriteLine("KITCHEN        :" + k);
                            Console.WriteLine();
                            Console.WriteLine("BALCONEY       :" + bal);
                            Console.WriteLine();
                        Z6: Console.WriteLine("1.YES\n\n2.NO\n\n3.DOES NOT CONTAIN THE REQUAIREMENTS");
                            sl = Convert.ToInt32(Console.ReadLine());
                            if (sl == 1)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                int doc;
                                string bn, bph, be;
                                Console.WriteLine("--------------------PLEASE ENTER YOUR DETAILS------------------\n");
                                Console.Write("YOUR NAME            :");
                                bn = Console.ReadLine();
                                Console.WriteLine();
                                Console.Write("YOUR PHONE NUMBER    :");
                                bph = Console.ReadLine();
                                Console.WriteLine();
                                Console.Write("YOUR E-Mail ID       :");
                                be = Console.ReadLine();
                                Console.WriteLine();
                                Console.Write("THE HOUSE SELLING COST IS      :");
                                cost = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine();
                            G: Console.WriteLine("DO YOU HAVE PROPER DOCUMENTS:\n");
                                Console.Write("1.YES\n\n2.NO\n");
                                doc = Convert.ToInt32(Console.ReadLine());
                                if (doc == 1)
                                {
                                    Console.WriteLine("++++++++++THANKYOU FOR SELLING++++++++++++++");
                                }
                                else if (doc == 2)
                                {
                                    Console.WriteLine("!NOT ACCEPTED");
                                }
                                else
                                {
                                    Console.WriteLine("entre valid option");
                                    goto G;
                                }
                                break;
                            }

                            else if (sl == 2)
                            {
                                Console.WriteLine("*************THANKYOU FOR VISITING**************");
                            }
                            else if (sl == 3)
                            {
                                Console.WriteLine("*************THANKYOU FOR VISITING**************");
                            }
                            else
                            {
                                Console.WriteLine("enter valid option:");
                                goto Z6;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter correct details");
                        goto F;
                    }
                }
                else if (spe == 2)
                {
                    Console.WriteLine("**********THANKYOU FOR VISITING*************");
                }
                else
                {
                    Console.WriteLine("enter valid option");
                    goto Z7;
                }

            }
            else
            {
                Console.WriteLine("enter valid option:");
                goto Z1;
            }
        }
        else if (ms == 2)
        {
            int sl;
            Console.Clear();
            Console.WriteLine("--------------------LAND MEDIATOR------------------------\n\n");
        L: Console.WriteLine("DO YOU WANT TO HAVE LOOK AT AVAILABLE LANDS[if you have any specifications please enter 2]\n\n");
            Console.WriteLine("1.YES\n\n2.NO\n");
            sl = Convert.ToInt32(Console.ReadLine());
            if (sl == 1)
            {
                int buy;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("------------HAVE A LOOK AT THE AVAILABLE LANDS---------------\n");
                Console.WriteLine();
                Console.WriteLine("1.ACERS             :10\n  \n*********COST      10000000/-*********");
                Console.WriteLine(); Console.WriteLine(); Thread.Sleep(1500);
                Console.WriteLine("2.ACERS             :20\n  \n*********COST      20000000/-*********");
                Console.WriteLine(); Console.WriteLine(); Thread.Sleep(1500);
                Console.WriteLine("3.ACERS             :7\n  \n*********COST      7000000/-*********");
                Console.WriteLine(); Console.WriteLine(); Thread.Sleep(1500);
                Console.WriteLine("4.ACERS             :15\n  \n*********COST      15000000/-*********");
                Console.WriteLine(); Console.WriteLine(); Thread.Sleep(1500);
                Console.WriteLine("5.ACERS             :25\n  \n*********COST      250000000/-*********");
                Console.WriteLine(); Console.WriteLine();
            L1: Console.WriteLine("DO YOU WANT TO BUY ANY ONE OF THESE LANDS[if you have any specifications please enter 2]\n");
                Console.WriteLine("1.YES\n\n2.NO\n");
                buy = Convert.ToInt32(Console.ReadLine());
                if (buy == 1)
                {
                    int wlb;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                L2: Console.Write("WHICH LAND DO YOU WANT BUY     :");
                    wlb = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    if (wlb == 1)
                    {
                        Console.WriteLine("1.ACERS             :10\n  \n*********COST      10000000/-*********");
                        Console.WriteLine();
                        Console.WriteLine("********************THANKYOU FOR BUYING************************");
                    }
                    else if (wlb == 2)
                    {
                        Console.WriteLine("2.ACERS             :20\n  \n*********COST      20000000/-*********");
                        Console.WriteLine();
                        Console.WriteLine("********************THANKYOU FOR BUYING************************");
                    }
                    else if (wlb == 3)
                    {
                        Console.WriteLine("3.ACERS             :7\n  \n*********COST      7000000/-*********");
                        Console.WriteLine();
                        Console.WriteLine("********************THANKYOU FOR BUYING************************");
                    }
                    else if (wlb == 4)
                    {
                        Console.WriteLine("4.ACERS             :15\n  \n*********COST      15000000/-*********");
                        Console.WriteLine();
                        Console.WriteLine("********************THANKYOU FOR BUYING************************");
                    }
                    else if (wlb == 5)
                    {
                        Console.WriteLine("5.ACERS             :25\n  \n*********COST      250000000/-*********");
                        Console.WriteLine();
                        Console.WriteLine("********************THANKYOU FOR BUYING************************");
                    }
                    else
                    {
                        Console.WriteLine("enter valid option:");
                        goto L2;
                    }
                }
                else if (buy == 2)
                {
                    int ha, stl;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    U1: Console.WriteLine("**********PLEASE MENTION YOUR SPECIFIATIONS OF LAND YOU WANT:***********");
                    Console.WriteLine(); Console.WriteLine();
                    Console.Write("HOW MANY ACERS YOU WANT       :");
                    ha = Convert.ToInt32(Console.ReadLine());
                    if (ha > 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("****************THANKYOU*******************");
                        while (true)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine("------ANY ONE WANT TO SELL THEIR LAND------:");
                            Console.WriteLine("IN ACERS           :" + ha);
                            Console.WriteLine();
                        L3: Console.WriteLine("1.YES\n\n2.NO\n\n3.DOES NOT CONTAIN THE REQUIREMENTS\n");
                            stl = Convert.ToInt32(Console.ReadLine());
                            if (stl == 1)
                            {
                                string bn, bph, be;
                                double landcost;
                                int doc;
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("--------------------PLEASE ENTER YOUR DETAILS-----------------\n");
                                Console.WriteLine(); Console.WriteLine();
                                Console.Write("YOUR NAME            :");
                                bn = Console.ReadLine();
                                Console.WriteLine();
                                Console.Write("YOUR PHONE NUMBER    :");
                                bph = Console.ReadLine();
                                Console.WriteLine();
                                Console.Write("YOUR E-Mail ID       :");
                                be = Console.ReadLine();
                                Console.WriteLine();
                                Console.Write("THE HOUSE SELLING COST IS      :");
                                landcost = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine();
                            G: Console.WriteLine("DO YOU HAVE PROPER DOCUMENTS:\n");
                                Console.Write("1.YES\n\n2.NO\n");
                                doc = Convert.ToInt32(Console.ReadLine());
                                if (doc == 1)
                                {
                                    Console.WriteLine("++++++++++THANKYOU FOR SELLING++++++++++++++");
                                }
                                else if (doc == 2)
                                {
                                    Console.WriteLine("!NOT ACCEPTED");
                                }
                                else
                                {
                                    Console.WriteLine("entre valid option");
                                    goto G;
                                }
                                break;
                            }
                            else if (stl == 2)
                            {
                                Console.WriteLine("**********THANKYOU FOR VISITING*************");
                            }
                            else if (stl == 3)
                            {
                                Console.WriteLine("**********THANKYOU FOR VISITING*************");
                            }
                            else
                            {
                                Console.WriteLine("enter valid options");
                                goto L3;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("please mention correct details:");
                        goto U1;
                    }
                }
                else
                {
                    Console.WriteLine("enter valid option");
                    goto L1;
                }
            }
            else if (sl == 2)
            {
                int ha, stl;
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                U2: Console.WriteLine("**********PLEASE MENTION YOUR SPECIFIATIONS WHICH LAND DO YOU WANT:***********");
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("HOW MANY ACERS YOU WANT       :");
                ha = Convert.ToInt32(Console.ReadLine());
                if (ha > 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("*********************THANKYOU*******************");
                    while (true)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ANY ONE WANT TO SELL THEIR LAND     :");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("IN ACERS           :" + ha);
                        Console.WriteLine();
                    L4: Console.WriteLine("1.YES\n\n2.NO\n\n3.DOES NOT CONTAIN THE REQUIREMENTS\n");
                        stl = Convert.ToInt32(Console.ReadLine());
                        if (stl == 1)
                        {
                            string bn, bph, be;
                            double landcost;
                            int doc;
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("--------------------PLEASE ENTER YOUR DETAILS SIR------------------");
                            Console.WriteLine(); Console.WriteLine();
                            Console.Write("YOUR NAME            :");
                            bn = Console.ReadLine();
                            Console.WriteLine();
                            Console.Write("YOUR PHONE NUMBER    :");
                            bph = Console.ReadLine();
                            Console.WriteLine();
                            Console.Write("YOUR E-Mail ID       :");
                            be = Console.ReadLine();
                            Console.WriteLine();
                            Console.Write("THE HOUSE SELLING COST IS      :");
                            landcost = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine();
                            Console.Clear();
                        G: Console.WriteLine("DO YOU HAVE PROPER DOCUMENTS:\n");
                            Console.Write("1.YES\n\n2.NO\n");
                            doc = Convert.ToInt32(Console.ReadLine());
                            if (doc == 1)
                            {
                                Console.WriteLine("++++++++++THANKYOU FOR SELLING++++++++++++++");
                            }
                            else if (doc == 2)
                            {
                                Console.WriteLine("!NOT ACCEPTED");
                            }
                            else
                            {
                                Console.WriteLine("enter valid option");
                                goto G;
                            }
                            break;
                        }
                        else if (stl == 2)
                        {
                            Console.WriteLine("**********THANKYOU FOR VISITING*************");
                        }
                        else if (stl == 3)
                        {
                            Console.WriteLine("**********THANKYOU FOR VISITING*************");
                        }
                        else
                        {
                            Console.WriteLine("enter valid options");
                            goto L4;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("please mention correct details:");
                    goto U2;
                }
            }
            else
            {
                Console.WriteLine("enter valid option");
                goto L;
            }
        }
        else
        {
            Console.WriteLine("enter valid option");
            goto Z;
        }
    }
}
class Realestate
{
    static string ph = "^[0-9].........$";
    static string u = "^[a-z]";
    static string pa = "^[0-9].....$";
    public static List<string> login = new List<string>();
    public static List<string> pass2 = new List<string>();
    public static List<string> login1 = new List<string>();
    public static List<string> pass3 = new List<string>();
    public static List<string> login2 = new List<string>();
    public static List<string> pass4 = new List<string>();
    public static void Main(string[] args)
    {
        int v, ms, reg, cut, cnt;
        string cn, cph, ce, user, pass, user1, pass1;
        Console.ForegroundColor = ConsoleColor.Green;
    A: Console.WriteLine("                                                                WELCOME TO GTDA VENTURES            ");
        Console.WriteLine("============================================================================================================================================================\n\n");
        mediator re = new mediator();
        Console.ForegroundColor = ConsoleColor.White;
        Regex n = new Regex(ph);
        Regex us = new Regex(u);
        Regex pa1 = new Regex(pa);
        Console.WriteLine(" ARE YOU\n\n1.SELLER\n\n2.BUYER\n\n3.MEDIATOR\n\n4.VIEW\n\n");
        v = Convert.ToInt32(Console.ReadLine());
        if (v == 1)
        {
            int nw;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("                                                                    **********SELLER REGISTRATION***********                                       ");
        H1: Console.WriteLine("ARE YOU A NEW REGISTER:\n\n");
            Console.WriteLine("1.YES\n\n2.NO\n");
            nw = Convert.ToInt32(Console.ReadLine());
            if (nw == 1)
            {
                string na, p, email, u2, p1, u1, p2;
                Console.Clear();
            V: Console.WriteLine("PLEASE SET YOUR USER ID AND PASSWORD:\n\n");
                L: Console.Write("USER ID(only lower case)        :");
                u1 = Console.ReadLine();
                Console.WriteLine();
                if (!us.IsMatch(u1))
                {
                    Console.WriteLine("Please enter valid user name");
                    goto L;
                }
                login.Add(u1);
                K: Console.Write("PASSWORD(only 6 digits)         :");
                p1 = Console.ReadLine();
                if (!pa1.IsMatch(p1))
                {
                    Console.WriteLine("Please enter valid password");
                    goto K;
                }
                pass2.Add(p1);
                Console.WriteLine();
                if (us.IsMatch(u1) && pa1.IsMatch(p1))
                {
                    Console.Clear();
                C5: Console.WriteLine("--------PLEASE LOG IN HERE------\n\n");
                    Console.Write("USER ID        :");
                    u2 = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write("PASSWORD       :");
                    p2 = Console.ReadLine();
                    Console.WriteLine();
                    if (u2==u1&&p2==p1)
                    {
                        Console.Clear();
                        Console.WriteLine("---------------------PLEASE WAIT-------------------");
                        Thread.Sleep(3000);
                         re.sell();
                        Console.Clear();
                        goto A;
                    }
                    else
                    {
                        Console.WriteLine("ENTER CORRECT USER NAME OR PASSWORD");
                        goto C5;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    goto V;
                }
            }
            else if (nw == 2)
            {
                string u2, p2;
                Console.Clear();
            H: Console.WriteLine("--------PLEASE LOGIN HERE------\n");
                Console.Write("USER ID        :");
                u2 = Console.ReadLine();
                Console.WriteLine();
                Console.Write("PASSWORD       :");
                p2 = Console.ReadLine();
                Console.WriteLine();
                cut = 0;
                cnt = login.Count;
                for (int i = 0; i < cnt; i++)
                {
                    if (u2 == login[i] && p2 == pass2[i])
                    {
                        cut = 1;
                        break;
                    }
                }
                if (cut == 1)
                {
                    Console.Clear();
                    re.sell();
                    Console.Clear();
                    goto A;
                }
                else
                {
                    Console.WriteLine("PLEASE COMPLETE REGISTRATION FIRST:");
                    goto H1;
                }
            }
            else
            {
                Console.WriteLine();
                Console.Clear();
                Console.Write("Enter correct option\n");
                goto H1;
            }
        }
        else if (v == 2)
        {
            int nw;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("**********BUYER REGISTRATION***********\n");
        H2: Console.WriteLine("ARE YOU NEW REGISTER:\n\n");
            Console.WriteLine("1.YES\n\n2.NO\n");
            nw = Convert.ToInt32(Console.ReadLine());
            if (nw == 1)
            {
                string na, p, email, u2, p1, u1, p2;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("PLEASE SET YOUR USER ID AND PASSWORD:\n\n");
                J: Console.Write("USER ID(only lower case)        :");
                u1 = Console.ReadLine();
                Console.WriteLine();
                if (!us.IsMatch(u1))
                {
                    Console.WriteLine("Please enter valid user name");
                    goto J;
                }
                login1.Add(u1);
                H: Console.Write("PASSWORD(only 6 digits)         :");
                p1 = Console.ReadLine();
                Console.WriteLine();
                if (!pa1.IsMatch(p1))
                {
                    Console.WriteLine("Please enter valid password");
                    goto H;
                }
                pass3.Add(p1);
                if (us.IsMatch(u1) && pa1.IsMatch(p1))
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                C1: Console.WriteLine("--------PLEASE LOGIN HERE------\n\n");
                    Console.Write("USER ID        :");
                    u2 = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write("PASSWORD       :");
                    p2 = Console.ReadLine();
                    Console.WriteLine();
                    if (u1 == u2 && p1 == p2)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("---------------------PLEASE WAIT-------------------");
                        Thread.Sleep(3000);
                        re.buy();
                        Console.Clear();
                        goto A;
                    }
                    else
                    {
                        Console.WriteLine("ENTER CORRECT USER NAME OR PASSWORD");
                        goto C1;
                    }
                }
            }
            else if (nw == 2)
            {
                string u2, p2;
                Console.Clear();
            H3: Console.WriteLine("--------PLEASE LOGIN HERE------");
                Console.Write("USER ID        :");
                u2 = Console.ReadLine();
                Console.WriteLine();
                Console.Write("PASSWORD       :");
                p2 = Console.ReadLine();
                Console.WriteLine();
                cut = 0;
                cnt=login1.Count;
                for (int i = 0; i < cnt; i++)
                {
                    if (u2 == login1[i] && p2 == pass3[i])
                    {
                        cut = 1;
                        break;
                    }
                }
                if (cut==1)
                {
                    Console.Clear();
                    re.buy();
                    Console.Clear();
                    goto A;
                }
                else
                {
                    Console.WriteLine("PLEASE REGISTER FIRST:");
                    goto H2;
                }
            }
            else
            {
                Console.WriteLine();
                Console.Clear();
                Console.Write("Enter correct option\n");
                goto H2;
            }
        }
        else if (v == 3)
        {
            int nw;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
        G5: Console.WriteLine("ARE YOU NEW REGISTER:\n");
            Console.WriteLine("1.YES\n\n2.NO\n");
            nw = Convert.ToInt32(Console.ReadLine());
          if (nw == 1)
            {
                Console.Clear();
                string na, p, email, u2, p1, u1, p2;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("**********MEADIATOR REGISTRATION***********\n\n");
                Console.WriteLine("PLEASE SET YOUR USER ID AND PASSWORD:\n\n");
                R: Console.Write("USER ID(only lower case)        :");
                u1 = Console.ReadLine();
                Console.WriteLine();
                if (!us.IsMatch(u1))
                {
                    Console.WriteLine("Please enter valid user name");
                    goto R;
                }
                login2.Add(u1);
                P: Console.Write("PASSWORD(only 6 digits)         :");
                p1 = Console.ReadLine();
                Console.WriteLine();
                if (!pa1.IsMatch(p1))
                {
                    Console.WriteLine("Please enter valid password");
                    goto P;
                }
                pass4.Add(p1);
                if (us.IsMatch(u1) && pa1.IsMatch(p1))
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                C: Console.WriteLine("--------PLEASE DO LOG IN HERE------\n\n");
                    Console.Write("USER ID        :");
                    u2 = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write("PASSWORD       :");
                    p2 = Console.ReadLine();
                    Console.WriteLine();
                    if (u1 == u2 && p1 == p2)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("---------------------PLEASE WAIT-------------------\n");
                        Thread.Sleep(3000);
                    M: Console.Write("NAME          :");
                        na = Console.ReadLine();
                        Console.WriteLine();
                        Console.Write("PHONE         :");
                        p = Console.ReadLine();
                        Console.WriteLine();
                        Console.Write("E-Mail        :");
                        email = Console.ReadLine();
                        Console.WriteLine();
                        if (n.IsMatch(p))
                        {
                            Console.Clear();
                            Console.WriteLine("---------------------PLEASE WAIT-------------------");
                            Thread.Sleep(3000);
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("============= REGISTERED SUCCESSFULLY ===================");
                            Thread.Sleep(2000);
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Blue;
                            goto A;

                        }
                        else
                        {
                            Console.WriteLine("PLEASE ENTRE THE CORRECT DETAILS:");
                            goto M;
                        }
                    }
                    else
                    {
                        Console.WriteLine("ENTER CORRECT USER NAME OR PASSWORD");
                        goto C;
                    }
                }
            }
            else if (nw == 2)
            {
                string u2, p2;
                if (login2.Count == 0)
                {
                    Console.WriteLine("No registrations has done yet");
                    Thread.Sleep(2000);
                    goto G5;
                }
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
            W1: Console.WriteLine("--------PLEASE LOGIN HERE------\n\n");
                Console.Write("USER ID        :");
                u2 = Console.ReadLine();
                Console.WriteLine();
                Console.Write("PASSWORD       :");
                p2 = Console.ReadLine();
                Console.WriteLine();
                cut = 0;
                cnt = login1.Count;
                for (int i = 0; i < cnt; i++)
                {
                    if (u2 == login2[i] && p2 == pass4[i])
                    {
                        cut = 1;
                        break;
                    }
                }
                if (cut==1)
                {
                    int l;
                    Console.Clear();
                    goto A;
                }
                else
                {
                    Console.WriteLine("enter correct user or password");
                    goto W1;
                }
            }
            else
            {
                Console.WriteLine("entre valid option:");
                goto G5;
            }
        }
        else if (v == 4)
        {
            re.display();
            goto A;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("ENTER VALID OPTION:");
            goto A;
        }
    }
}