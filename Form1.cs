using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        
    }



    public class Simulation
    {
        Balance _balance;
        AdBudget _adBudget;
        Orders _orders;

        public Simulation(decimal balance, decimal rent, decimal salaries, decimal amountOfMoney, decimal speed)
        {

        }


        public void TimeTick()
        {

        }
    }
    

    public class Balance
    {
        public decimal Value { get; set; }
        private decimal _inredientsCost;
        private decimal _salaries;
        private decimal _rent;

        public void MonthPayment()
        {
            Value -= (_inredientsCost + _salaries + _rent);
        }
        public void Income(decimal income)
        {
            Value += income;
        }
    }


    public class AdBudget
    {
        const decimal _coefficient = 0.2M;
        public decimal Value { get; set; }

        public void SetAdBudget(Balance balance)
        {
            Value = balance.Value * _coefficient;
        }
    }

    public class Orders
    {
        public int Amount { get; set; }
        public int ClientsFlow { get; set; }
        public int AdEfficiency { get; set; }

        public void SetAmountOfOrders()
        {
            //установить количество заказов в зависимости от потока клиентов и эффективности рекламы! (эфф. рекламы как
            //множитель или как слагаемое)
        }
    }

    public class OrdersList
    {
        string[] orders;//примерно так!!!
    }

}
