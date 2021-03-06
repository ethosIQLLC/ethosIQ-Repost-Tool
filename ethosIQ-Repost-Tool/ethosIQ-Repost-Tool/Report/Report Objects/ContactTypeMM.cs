﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ethosIQ_Repost_Tool.Report.Report_Objects
{
    public class ContactTypeMM
    {
        public string CT;
        public int Received;
        public int Handled;
        public int Aban;
        public int Ans_Gos;
        public int Aba_Gos;
        public int HandleTime;
        public int WorkTime;
        public int Distributed;
        public int Q_Delay;
        public int Srlvl;
        public int Blog;
        public int BlogNotExp;
        public int BlogExp;

        public ContactTypeMM(string CT, int Received, int Handled, int Aban, int Ans_Gos, int Aba_Gos, int HandleTime, int WorkTime, int Distributed, int Q_Delay, int Srlvl, int Blog, int BlogNotExp, int BlogExp)
        {
            this.CT = CT;
            this.Received = Received;
            this.Handled = Handled;
            this.Aban = Aban;
            this.Ans_Gos = Ans_Gos;
            this.Aba_Gos = Aba_Gos;
            this.HandleTime = HandleTime;
            this.WorkTime = WorkTime;
            this.Distributed = Distributed;
            this.Q_Delay = Q_Delay;
            this.Srlvl = Srlvl;
            this.Blog = Blog;
            this.BlogNotExp = BlogNotExp;
            this.BlogExp = BlogExp;

        }

        public override string ToString()
        {
            return CT + "\t" + Received + "\t" + Handled + "\t" + Aban + "\t" + Ans_Gos + "\t" + Aba_Gos + "\t" + HandleTime + "\t" + WorkTime + "\t" + Distributed + "\t" + Q_Delay + "\t" + Srlvl + "\t" + Blog + "\t" + BlogNotExp + "\t" + BlogExp + "\t";
        }
    }
}
