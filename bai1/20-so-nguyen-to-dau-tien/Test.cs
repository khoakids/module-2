using System;
using System.Diagnostics;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace _20_so_nguyen_to_dau_tien
{
    public class Test
    {

        [DebuggerNonUserCode]
        public Test()
        {
        }

        private static string getNum(string sSoTien)
        {
            string str;
            str = (sSoTien.Length < 3 ? Strings.Right(sSoTien, sSoTien.Length) : Strings.Right(sSoTien, 3));
            return str;
        }

        public static string Num2Text(string sSoTien)
        {
            byte num = 0;
            string str;
            string str1;
            string[] strArrays = Strings.Split(sSoTien, ".", -1, CompareMethod.Binary);
            sSoTien = strArrays[0];
            string[] strArrays1 = new string[] { "", "nghìn ", "triệu ", "tỷ ", "ngàn ", "triệu " };
            string[] strArrays2 = strArrays1;
            string str2 = "";
            while (!sSoTien.Equals(""))
            {
                if (sSoTien.Length != 0)
                {
                    string num1 = Test.getNum(sSoTien);
                    sSoTien = Strings.Left(sSoTien, checked(sSoTien.Length - num1.Length));
                    str1 = Test.setNum(num1);
                    num1 = str1;
                    if (!num1.Equals(""))
                    {
                        str1 = string.Concat(str1, strArrays2[num]);
                        str2 = string.Concat(str1, str2);
                    }
                    num = checked((byte)(checked(num + 1)));
                }
            }
            str1 = Strings.UCase(Strings.Left(str2, 1));
            try
            {
                str = string.Concat(str1, Strings.Right(str2, checked(Strings.Len(str2) - 1)), "đồng./.");
            }
            catch (Exception exception)
            {
                ProjectData.SetProjectError(exception);
                str = "";
                ProjectData.ClearProjectError();
            }
            return str;
        }

        private static string setNum(string sSoTien)
        {
            bool flag = false;
            bool flag1 = false;
            string str = "";
            string str1 = sSoTien;
            string[] strArrays = new string[] { "không ", "một ", "hai ", "ba ", "bốn ", "năm ", "sáu ", "bảy ", "tám ", "chín " };
            string[] strArrays1 = strArrays;
            if (sSoTien.Length == 3)
            {
                if (Conversions.ToDouble(Strings.Left(sSoTien, 1)) == 0 & Conversions.ToDouble(Strings.Left(Strings.Right(sSoTien, 2), 1)) == 0 & Conversions.ToDouble(Strings.Right(sSoTien, 1)) == 0)
                {
                    str = string.Concat(strArrays1[Conversions.ToInteger(Strings.Left(sSoTien, 1))], "trăm ");
                }
                sSoTien = Strings.Right(sSoTien, 2);
            }
            if (sSoTien.Length == 2)
            {
                if (Conversions.ToDouble(Strings.Left(sSoTien, 1)) == 0)
                {
                    if (Conversions.ToDouble(Strings.Right(sSoTien, 1)) != 0)
                    {
                        str = string.Concat(str, "lẻ ");
                    }
                    flag = true;
                }
                else if (Conversions.ToDouble(Strings.Left(sSoTien, 1)) != 1)
                {
                    str = string.Concat(str, strArrays1[Conversions.ToInteger(Strings.Left(sSoTien, 1))], "mươi ");
                    flag1 = true;
                }
                else
                {
                    str = string.Concat(str, "mười ");
                }
                sSoTien = Strings.Right(sSoTien, 1);
            }
            if (Conversions.ToDouble(Strings.Right(sSoTien, 1)) != 0)
            {
                if (!(Conversions.ToDouble(Strings.Left(sSoTien, 1)) == 5 & !flag))
                {
                    str = (!(Conversions.ToDouble(Strings.Left(sSoTien, 1)) == 1 & !(!flag1 | flag) & Operators.CompareString(str, "", false) != 0) ? string.Concat(str, strArrays1[Conversions.ToInteger(Strings.Left(sSoTien, 1))], "") : string.Concat(str, "mốt "));
                }
                else
                {
                    str = (str1.Length != 1 ? string.Concat(str, "lăm ") : string.Concat(str, "năm "));
                }
            }
            return str;
        }
    }
}