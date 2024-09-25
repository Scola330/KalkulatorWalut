namespace waluty
{
    public partial class Form1 : Form
    {
        Dictionary<string, double> wymiana = new Dictionary<string, double>();
        public Form1()
        {
            InitializeComponent();
            wymiana.Add("PLNPLN", 1.0000);
            wymiana.Add("PLNUSD", 3.8117);
            wymiana.Add("PLNEUR", 4.2634);
            wymiana.Add("PLNRUB", 0.0410);
            wymiana.Add("PLNTHB", 0.1166);
            wymiana.Add("USDUSD", 1.0000);
            wymiana.Add("USDPLN", 3.8117);
            wymiana.Add("USDEUR", 0.8941);
            wymiana.Add("USDRUB", 92.9683);
            wymiana.Add("USDTHB", 32.6904);
            wymiana.Add("EUREUR", 1.0000);
            wymiana.Add("EURPLN", 4.2634);
            wymiana.Add("EURUSD", 0.8941);
            wymiana.Add("EURRUB", 103.9854);
            wymiana.Add("EURTHB", 36.5643);
            wymiana.Add("RUBRUB", 0.0410);
            wymiana.Add("RUBPLN", 0.0410);
            wymiana.Add("RUBUSD", 92.9683);
            wymiana.Add("RUBEUR", 103.9854);
            wymiana.Add("RUBTHB", 0.3516);
            wymiana.Add("THBTHB", 1.0000);
            wymiana.Add("THBPLN", 0.1166);
            wymiana.Add("THBUSD", 32.6904);
            wymiana.Add("THBEUR", 36.5643);
            wymiana.Add("THBRUB", 0.3516);

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        public void oblicz(object sender, EventArgs e)
        {
            string from = "PLN";
            decimal iloscWaluty = Kwota.Value;
            double wartoscKosztu = Convert.ToDouble(iloscWaluty);
            if (SUSD.Checked)
            {
                from = "USD";
            }
            else if (SEUR.Checked)
            {
                from = "EUR";
            }
            else if (SRUB.Checked)
            {
                from = "RUB";
            }
            else if (STHB.Checked)
            {
                from = "THB";
            }
            else if (SPLN.Checked)
            {
                from = "PLN";
            }

            if (TPLN.Checked)
            {
                from = from + "PLN";
            }
            else if (TUSD.Checked)
            {
                from = from + "USD";
            }
            else if (TEUR.Checked)
            {
                from = from + "EUR";
            }
            else if (TRUB.Checked)
            {
                from = from + "RUB";
            }
            else if (TTHB.Checked)
            {
                from = from + "THB";
            }

            double iloscZloty = wartoscKosztu;
            string wynik = string.Empty;
            string aktywne = string.Empty;
            if (from == "PLNPLN")
            {
                wynik = Math.Round(iloscZloty, 2) + " PLN";
            }
            else if (from == "USDUSD")
            {
                wynik = Math.Round(iloscZloty, 2) + " USD";
            }
            else if (from == "EUREUR")
            {
                wynik = Math.Round(iloscZloty, 2) + " EUR";
            }
            else if (from == "RUBRUB")
            {
                wynik = Math.Round(iloscZloty, 2) + " RUB";
            }
            else if (from == "THBTHB")
            {
                wynik = Math.Round(iloscZloty, 2) + " THB";
            }
            else if (from == "PLNUSD")
            {
                wynik = Math.Round(iloscZloty / wymiana["PLNUSD"], 2) + " USD";
            }
            else if (from == "PLNEUR")
            {
                wynik = Math.Round(iloscZloty / wymiana["PLNEUR"], 2) + " EUR";
            }
            else if (from == "PLNRUB")
            {
                wynik = Math.Round(iloscZloty / wymiana["PLNRUB"], 2) + " RUB";
            }
            else if (from == "PLNTHB")
            {
                wynik = Math.Round(iloscZloty / wymiana["PLNTHB"], 2) + " THB";
            }
            else if (from == "USDPLN")
            {
                wynik = Math.Round(iloscZloty * wymiana["USDPLN"], 2) + " PLN";
            }
            else if (from == "USDEUR")
            {
                wynik = Math.Round(iloscZloty * wymiana["USDEUR"], 2) + " EUR";
            }
            else if (from == "USDRUB")
            {
                wynik = Math.Round(iloscZloty * wymiana["USDRUB"], 2) + " RUB";
            }
            else if (from == "USDTHB")
            {
                wynik = Math.Round(iloscZloty * wymiana["USDTHB"], 2) + " THB";
            }
            else if (from == "EURPLN")
            {
                wynik = Math.Round(iloscZloty * wymiana["EURPLN"], 2) + " PLN";
            }
            else if (from == "EURUSD")
            {
                wynik = Math.Round(iloscZloty / wymiana["EURUSD"], 2) + " USD";
            }
            else if (from == "EURRUB")
            {
                wynik = Math.Round(iloscZloty * wymiana["EURRUB"], 2) + " RUB";
            }
            else if (from == "EURTHB")
            {
                wynik = Math.Round(iloscZloty * wymiana["EURTHB"], 2) + " THB";
            }
            else if (from == "RUBPLN")
            {
                wynik = Math.Round(iloscZloty * wymiana["RUBPLN"], 2) + " PLN";
            }
            else if (from == "RUBUSD")
            {
                wynik = Math.Round(iloscZloty / wymiana["RUBUSD"], 2) + " USD";
            }
            else if (from == "RUBEUR")
            {
                wynik = Math.Round(iloscZloty / wymiana["RUBEUR"], 2) + " EUR";
            }
            else if (from == "RUBTHB")
            {
                wynik = Math.Round(iloscZloty * wymiana["RUBTHB"], 2) + " THB";
            }
            else if (from == "THBPLN")
            {
                wynik = Math.Round(iloscZloty * wymiana["THBPLN"], 2) + " PLN";
            }
            else if (from == "THBUSD")
            {
                wynik = Math.Round(iloscZloty / wymiana["THBUSD"], 2) + " USD";
            }
            else if (from == "THBEUR")
            {
                wynik = Math.Round(iloscZloty / wymiana["THBEUR"], 2) + " EUR";
            }
            else if (from == "THBRUB")
            {
                wynik = Math.Round(iloscZloty / wymiana["THBRUB"], 2) + " RUB";
            }
            label1.Text = wynik;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Kwota_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
