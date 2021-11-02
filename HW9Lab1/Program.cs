/// Homework No. 9 Lab No. 1
/// File Name : Program.cs
/// @author : Joshua Um
/// Date : November 1 2021
/// 
/// Problem Statement : Define a class named Payment that contains an instance variable of type double that stores the amount of the payment and appropriate getter and setter methods
/// Then, Define a class named CreditCardPayment that is derived from Payment.  This class should contain instance variables for the name on the card, and credit card number. 
/// 
/// Plan:
/// 1. Create 2 CashPayment objects with varying payments.
/// 2. Call PaymentDetails() on each.
/// 3. Create 2 CreditCardPayment objects passing varied data.
/// 4. Call PaymentDetails() on each.
using System;

namespace HW9Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            new CashPayment(99.42).PaymentDetails();
            new CashPayment(13.33).PaymentDetails();

            new CreditCardPayment("NoviceCard", 11111111 , 199.99).PaymentDetails();
            new CreditCardPayment("ExperiencedCard", 2222222, 999.99).PaymentDetails();
        }
    }

    class Payment
    {
        public double AmountPaid { get; set; }


        public Payment(double amountPaid)
        {
            AmountPaid = amountPaid;
        }

        public virtual void PaymentDetails()
        {
            Console.WriteLine("Amount Paid : " + AmountPaid + "\n");
        }


    }

    class CashPayment : Payment
    {
        public CashPayment(double amountPaid) : base(amountPaid)
        {

        }

        public override void PaymentDetails()
        {
            Console.WriteLine("Amount Paid : " + AmountPaid + "\n Type of Payment : Cash" + "\n");
        }
    }


    class CreditCardPayment : Payment
    {
        public string CardName { get; set; }
        public int CardNumber { get; set; }

        public CreditCardPayment(string cardName, int cardNumber, double amountPaid) : base(amountPaid)
        {
            CardName = cardName;
            CardNumber = cardNumber;
        }

        public override void PaymentDetails()
        {
            Console.WriteLine("Amount Paid : " + AmountPaid + "\n Card Name : " + CardName + "\n Card # : " + CardNumber +"\n");
        }




    }
}
