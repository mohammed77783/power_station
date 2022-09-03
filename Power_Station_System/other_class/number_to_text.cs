using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power_Station_System.other_class
{
    class number_to_text
    { 

  static   public string convertcurrency(string Money, string Fullcurency, string partcurrency)
        {
            string MA = " " + Fullcurency;
            string MI = " " + partcurrency;
            string X = Money;
            double N = Math.Floor(double.Parse(X));
            double B = Math.Round(double.Parse(X), 2);
            double B2 = B - Math.Floor(B); B2 *= 100;
            string r = SConvertCurrency(N);
            string t;
            t = r.ToString() + MA + "  " + Math.Round(Math.Ceiling(B2), 0) + MI;
            return t;
        }


        static public string SConvertCurrency(double Money)
        {
            string C = Money.ToString();
            char[] MoneyChars = C.ToCharArray();
            char[] cMoney = MoneyChars.Reverse().ToArray();
            int ArrayCount = cMoney.Count();
            string R = "";
            for (int i = 1; i <= ArrayCount; ++i)
            {
                if (i == 1)
                {
                    R = MoneyOnes(cMoney);
                }
                if (i == 2)
                {
                    if (cMoney[0] != char.Parse("0") &
                          cMoney[1] > char.Parse("1"))
                        R = MoneyOnes(cMoney) + " و" + MoneyTens(cMoney);
                    if (cMoney[1] == char.Parse("0"))
                        R = MoneyOnes(cMoney);
                    if (cMoney[0] == char.Parse("0") &
                          cMoney[1] == char.Parse("1"))
                        R = MoneyTens(cMoney) + "ة";
                    if (cMoney[0] == char.Parse("1") &
                          cMoney[1] == char.Parse("1"))
                        R = "عشر أحد";
                    if (cMoney[0] == char.Parse("2") &
                          cMoney[1] == char.Parse("1"))
                        R = " اثنا عشر";
                    if (cMoney[0] > char.Parse("2") &
                           cMoney[1] == char.Parse("1"))
                        R = MoneyOnes(cMoney) + " " + MoneyTens(cMoney);
                    if (cMoney[0] == char.Parse("0") &
                         cMoney[1] != char.Parse("0"))
                        R = MoneyTens(cMoney);
                }
                if (i == 3)
                {
                    if (MoneyHundreds(cMoney) != "")
                    {
                        if (cMoney[0] != char.Parse("0") &
                             cMoney[1] != char.Parse("0"))
                            R = MoneyHundreds(cMoney) + " و" + R;
                        if (cMoney[0] == char.Parse("0") &
                              cMoney[1] != char.Parse("0"))
                            R = MoneyHundreds(cMoney) + " و" + MoneyTens(cMoney);
                        if (cMoney[0] != char.Parse("0") &
                             cMoney[1] == char.Parse("0"))
                            R = MoneyHundreds(cMoney) + " و" + MoneyOnes(cMoney);
                        if (cMoney[0] == char.Parse("0") &
                              cMoney[1] == char.Parse("0"))
                            R = MoneyHundreds(cMoney);
                    }
                }
                if (i == 4)
                {
                    if (MoneyThousands(cMoney) != "")
                    {
                        if (SConvertCurrency(OtherUnits(cMoney)) != "")
                            R = MoneyThousands(cMoney) + " و" + SConvertCurrency(OtherUnits(cMoney));
                        else
                            R = MoneyThousands(cMoney);
                    }
                }
                if (i == 5)
                {
                    string TenThousands = SConvertCurrency(
                        double.Parse(cMoney[4].ToString() + cMoney[3].ToString()));
                    if (TenThousands != "")
                    {
                        if (TenThousands == "عشر") TenThousands += "آلاف ة ";
                        else TenThousands += " ألف ";
                        if (SConvertCurrency(OtherUnits2(cMoney)) != "")
                            R = TenThousands + " و" + SConvertCurrency(OtherUnits2(cMoney));
                        else R = TenThousands;
                    }
                }
                if (i == 6)
                {
                    string HundredThousands = SConvertCurrency(double.Parse(cMoney[5].ToString() + cMoney[4].ToString() + cMoney[3].ToString())) + " ألف ";
                    if (HundredThousands != "")
                    {
                        if (cMoney[4] == '0' & cMoney[3] != '0')
                        {
                            if (cMoney[3] == '1')

                                HundredThousands =
                              SConvertCurrency((double.Parse(cMoney[5].ToString() + "00"))) + "وألف ";
                            else if (cMoney[3] == '2')
                                HundredThousands =
                                    SConvertCurrency((double.Parse(cMoney[5].ToString() + "00"))) + " وألفان ";
                            else
                                HundredThousands =
                                    SConvertCurrency((double.Parse(cMoney[5].ToString() + "00"))) + "و " +
                                    SConvertCurrency(double.Parse(cMoney[3].ToString())) + "آلاف  ";
                        }
                        if (SConvertCurrency(OtherUnits3(cMoney)) != "")
                            R = HundredThousands +
                                 " و " + SConvertCurrency(OtherUnits3(cMoney));
                        else
                            R = HundredThousands;
                    }
                }
                if (i == 7)
                {
                    if (MoneyMillions(cMoney) != "")
                    {
                        if (SConvertCurrency(OtherUnits(cMoney)) != "")
                            R = MoneyMillions(cMoney) +
                           " و " + SConvertCurrency(OtherUnits(cMoney));
                        else
                            R = MoneyMillions(cMoney);
                    }
                }
                if (i == 8)
                {
                    string TenMillions = SConvertCurrency(double.Parse(cMoney[7].ToString() + cMoney[6].ToString()));
                    if (TenMillions != "")
                    {
                        if (TenMillions == "عشر") TenMillions += "ملايين ة  ";
                        else TenMillions += " مليون";
                        if (SConvertCurrency(OtherUnits2(cMoney)) != "")
                            R = TenMillions +
                                 " و " + SConvertCurrency(OtherUnits2(cMoney));
                        else R = TenMillions;
                    }
                }
                if (i == 9)
                {
                    string HundredMillions = SConvertCurrency(
                        double.Parse(cMoney[8].ToString() + cMoney[7].ToString() + cMoney[6].ToString())) + " مليون ";
                    if (HundredMillions != "")
                    {
                        if (cMoney[7] == '0' & cMoney[6] != '0')
                        {
                            if (cMoney[6] == '1')
                                HundredMillions =
                            SConvertCurrency((double.Parse(cMoney[8].ToString() + "00"))) + " ومليون ";
                            else if (cMoney[6] == '2')
                                HundredMillions =
                     SConvertCurrency((double.Parse(cMoney[8].ToString() + "00"))) + " ومليونان  ";
                            else
                                HundredMillions =
                     SConvertCurrency((double.Parse(cMoney[8].ToString() + "00"))) + "و " +
                     SConvertCurrency(double.Parse(cMoney[6].ToString())) + "ملايين ";
                        }
                        if (SConvertCurrency(OtherUnits3(cMoney)) != "")
                            R = HundredMillions +
                       " و" + SConvertCurrency(OtherUnits3(cMoney));
                        else
                            R = HundredMillions;
                    }
                }
                if (i == 10)
                {
                    if (MoneyBillions(cMoney) != "")
                    {
                        if (SConvertCurrency(OtherUnits(cMoney)) != "")
                            R = MoneyBillions(cMoney) + " و " + SConvertCurrency(OtherUnits(cMoney));
                        else
                            R = MoneyBillions(cMoney);
                    }
                }
                if (i == 11)
                {
                    string TenBillions = SConvertCurrency(
                    double.Parse(cMoney[10].ToString() + cMoney[9].ToString()));
                    if (TenBillions != "")
                    {
                        if (TenBillions == "عشر") TenBillions += "مليارات ة ";
                        else
                            TenBillions += " مليار  ";
                        if (SConvertCurrency(OtherUnits2(cMoney)) != "")
                            R = TenBillions + " و " + SConvertCurrency(OtherUnits2(cMoney));
                        else R = TenBillions;
                    }
                }
                if (i > 11)
                {
                    R = "";
                }
            }
            return R;
        }
        static public string MoneyOnes(params char[] c)
        {
            switch (int.Parse(c[0].ToString()))
            {
                case 1:
                    return " واحد";
                case 2:
                    return "اثنان";
                case 3:
                    return "ثلاث";
                case 4:
                    return "اربع";
                case 5:
                    return "خمس";
                case 6:
                    return "ست";
                case 7:
                    return "سبع";
                case 8:
                    return "ثمان";
                case 9:
                    return "تسع";
                default:
                    return "";
            }
        }
        static public string MoneyTens(params char[] c)
        {
            switch (int.Parse(c[1].ToString()))
            {
                case 1:
                    return "عشر";
                case 2:
                    return "عشرون";
                case 3:
                    return "ثلاثون";
                case 4:
                    return "اربعون";
                case 5:
                    return "خمسون";
                case 6:
                    return "ستون";
                case 7:
                    return "سبعون";
                case 8:
                    return "ثمانون";
                case 9:
                    return "تسعون";
                default:
                    return "";
            }
        }
        static public string MoneyHundreds(params char[] c)
        {
            switch (int.Parse(c[2].ToString()))
            {
                case 1:
                    return "مئه";
                case 2:
                    return "مئتان";
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                    {
                        return MoneyOnes(char.Parse(c[2].ToString())) + " مئة ";
                    }
                default:
                    return "";
            }
        }
        static public string MoneyThousands(params char[] c)
        {
            switch (int.Parse(c[3].ToString()))
            {
                case 1:
                    return " الف";
                case 2:
                    return "الفان";
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                    {
                        return MoneyOnes(char.Parse(c[3].ToString())) + " الالف ";
                    }
                default:
                    return "";
            }
        }
        static public string MoneyMillions(params char[] c)
        {
            switch (int.Parse(c[6].ToString()))
            {
                case 1:
                    return "مليون";
                case 2:
                    return "مليونان";
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                    {
                        return MoneyOnes(char.Parse(c[6].ToString())) + " ملايين ";
                    }
                default:
                    return "";
            }
        }
        static public string MoneyBillions(params char[] c)
        {
            switch (int.Parse(c[9].ToString()))
            {
                case 1:
                    return "مليار";
                case 2:
                    return "ملياران";
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                    {
                        return MoneyOnes(char.Parse(c[9].ToString())) + "مليارات  ";
                    }
                default:
                    return "";
            }
        }
        static public double OtherUnits(params char[] c)
        {
            string t = "";
            for (int j = c.Length; j > 1; --j)
                t += c[j - 2].ToString();
            return double.Parse(t);
        }
        static public double OtherUnits2(params char[] c)
        {
            string t = "";
            for (int j = c.Length; j > 2; --j)
                t += c[j - 3].ToString();
            return double.Parse(t);
        }
        static public double OtherUnits3(params char[] c)
        {
            string t = "";
            for (int j = c.Length; j > 3; --j)
                t += c[j - 4].ToString();
            return double.Parse(t);
        }

    }
}
