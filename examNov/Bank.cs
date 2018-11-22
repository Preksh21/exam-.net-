using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examNov
{
    class Bank
    {
        public int a;
        public int b;
        public int c;
        public int d;
        public int e;
        public int f;

        public Bank()
        {
            a = 0;
            b = 0;
            c = 0;
            d = 0;
            e = 0;
            f = 0;

        }
        public Bank(int Name, int ID, int ACno, int TtlAmt , int Deposit, int Withdraw)
        {
            a = Name;
            b = ID;
            c = ACno;
            d = TtlAmt;
            e = Deposit;
            f = Withdraw;
        }
        public int getName()
        {
            return a;
        }
        public int getID()
        {
            return b;

        }
        public int getACno()
        {
            return c;
        }
        public int getTtlAmt()
        {
            return d;
        }
        public int getDeposit()
        {
            return e;
        }
        public int getWithdraw()
        {
            return f;
        }
        public void setName(int Name)
        {
            a = Name;
        }
        public void setID(int ID)
        {
            b = ID;
        }
        public void setACno(int ACNo)
        {
            c = ACNo;
        }
        public void setTtlAmt(int TtlAmt)
        {
            d = TtlAmt;
        }
        public void setDeposit(int Deposit)
        {
            e = Deposit;
        }
        public void setWithdraw(int Withdraw)
        {
            f = Withdraw;
        }



    }
}
