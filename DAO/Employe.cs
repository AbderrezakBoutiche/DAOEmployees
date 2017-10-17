using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class Employe
    {
        private string _ENAME;

        public string ENAME
        {
            get { return _ENAME; }
            set { _ENAME = value; }
        }
        private string _JOB;

        public string JOB
        {
            get { return _JOB; }
            set { _JOB = value; }
        }

        private decimal _SAL;

        public decimal SAL
        {
            get { return _SAL; }
            set { _SAL = value; }
        }
        private decimal _COMM;

        public decimal COMM
        {
            get { return _COMM; }
            set { _COMM = value; }
        }
        private DateTime _HIREDATE;

        public DateTime HIREDATE
        {
            get { return _HIREDATE; }
            set { _HIREDATE = value; }
        }
        private int _MGR;

        public int MGR
        {
            get { return _MGR; }
            set { _MGR = value; }
        }

        private int _DEPTNO;

        public int DEPTNO
        {
            get { return _DEPTNO; }
            set { _DEPTNO = value; }
        }

        // Les Contructeurs
        #region Constructeurs
        public Employe(string _ENAME, string _JOB, decimal _SAL, decimal _COMM, DateTime _HIREDATE, int _MGR, int _DEPTNO)
        {
            this.ENAME = _ENAME.ToUpper();
            this.JOB = _JOB.ToUpper();
            this.SAL = _SAL;
            this.COMM = _COMM;
            this.HIREDATE = _HIREDATE;
            this.MGR = _MGR;
            this.DEPTNO = _DEPTNO;
            
        }
        public Employe(string _ENAME, string _JOB, decimal _SAL, decimal _COMM, int _MGR, int _DEPTNO)
        {
            this.ENAME = _ENAME.ToUpper();
            this.JOB = _JOB.ToUpper();
            this.SAL = _SAL;
            this.COMM = _COMM;
            this.HIREDATE = DateTime.Today;
            this.MGR = _MGR;
            this.DEPTNO = _DEPTNO;

        }

        public Employe() { } //Constructeur défaut
        #endregion
    }



    //TODO Constructeur



}

