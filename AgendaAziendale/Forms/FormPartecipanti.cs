using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgendaAziendale.Modelli;
using AgendaAziendale.Forms.UserControls;

namespace AgendaAziendale.Forms
{
    public partial class FormPartecipanti : Form
    {
        #region Attributi
        private Form formPadre;
        private UserControl ucPadre;
        private Attivita att;
        private List<Lavoratore> elencoLavoratori;
        private readonly string tipologia;
        #endregion

        #region Getters & Setters
        public Form FormPadre { get => formPadre; set => formPadre = value; }
        public UserControl UcPadre { get => ucPadre; set => ucPadre = value; }
        public Attivita Att { get => att; set => att = value; }
        public List<Lavoratore> ElencoLavoratori { get => elencoLavoratori; set => elencoLavoratori = value; }
        #endregion

        /// <summary>
        /// Metodo costruttore del form FormPartecipanti
        /// </summary>
        /// <param name="formPadre"></param>
        /// <param name="ucPadre"></param>
        /// <param name="att"></param>
        /// <param name="tipologia"></param>
        public FormPartecipanti(Form formPadre, UserControl ucPadre, Attivita att, string tipologia)
        {
            InitializeComponent();
            FormPadre = formPadre;
            UcPadre = ucPadre;
            Att = att;
            ElencoLavoratori = new List<Lavoratore>();
            this.tipologia = tipologia;
        }

        #region Ascoltatori eventi
        /// <summary>
        /// Metodo richiamato al caricamento dell'interfaccia
        ///  --> settaggio gerarchie interfaccia
        ///  --> settaggio attributi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormPartecipanti_Load(object sender, EventArgs e)
        {
            ///Figli del Form
            panelTop.Parent = this;
            panelCentro.Parent = this;
            ///Figli del pannello top
            btChiudi.Parent = panelTop;
            ///Figli del pannello centrale
            lbLavoratore.Parent = panelCentro;
            cbLavoratore.Parent = panelCentro;
            lbRuolo.Parent = panelCentro;
            cbRuolo.Parent = panelCentro;   
            btAggiungi.Parent = panelCentro;
            dgvPartecipanti.Parent = panelCentro;

            CaricaCBLavoratori();
            AggiornadgvPartecipanti();

            if ((tipologia == "Evento") || (tipologia == "evento"))
            {
                UcPadre = (UCEventi)UcPadre;
                Att = (Evento)Att;
            }

            else if ((tipologia == "Progetto") || (tipologia == "progetto"))
            {
                UcPadre = (UCProgetti)UcPadre;
                Att = (Progetto)Att;

                lbRuolo.Visible = true;
                cbRuolo.Visible = true;
                cbRuolo.Enabled = true;
            }

            else
            {
                MessageBox.Show("ERRORE! Valore FormPartecipanti:tipologia --> controllare stack chiamate!", "Compilazione campi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        /// <summary>
        /// Ascoltatore evento click sul bottone di chiusura 
        /// --> chiusura form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtChiudi_Click(object sender, EventArgs e)
        {
            FormPadre.Show();
            Close();
        }

        /// <summary>
        /// Ascoltatore click sul bottone di aggiunta ad un'attività
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtAggiungi_Click(object sender, EventArgs e)
        {
            if(CheckCampi())
            {
                AggiungiPartecipante();
                AggiornadgvPartecipanti();
            }           
        }

        /// <summary>
        /// Ascoltatore click sulla cella di eliminazione
        /// --> eliminazione partecipazione corrispettiva
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvPartecipanti_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Click sulla colonna con i button d'eliminazione
            if (e.ColumnIndex == 3)
            {
                if (MessageBox.Show("Sei sicuro di voler procedere con l'eliminazione della partecipazione selezionata? Tutte le informazioni ad essa collegate verranno eliminate.",
                    "Eliminazione", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string username = dgvPartecipanti.Rows[e.RowIndex].Cells[0].Value.ToString(); ///Username della riga selezionata
                    string codice = dgvPartecipanti.Rows[e.RowIndex].Cells[1].Value.ToString(); ///Codice della riga selezionata

                    if (Controller.EliminaPartecipazioneAttivita(username, codice))
                    {
                        MessageBox.Show("Eliminazione partecipazione avvenuta con successo!", "FormPartecipanti", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AggiornadgvPartecipanti();
                    }

                    else
                        MessageBox.Show("ERRORE! Impossibile eliminare la partecipazione dal DB, contattare l'amministrazione.", "FormPartecipanti", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        /// <summary>
        /// Click sulla combobox relativa alla selezione del ruolo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbRuolo_Enter(object sender, EventArgs e)
        {
            cbRuolo.BackColor = Color.White;
        }

        /// <summary>
        /// Click sulla combobox relativa alla selezione del ruolo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbLavoratore_Enter(object sender, EventArgs e)
        {
            cbLavoratore.BackColor = Color.White;
        }
        #endregion

        #region Metodi
        /// <summary>
        /// Metodo adibito al caricamento della combobox
        /// </summary>
        private void CaricaCBLavoratori()
        {
            string result = Controller.GetElencoLavoratoriAttivita(Att.Codice);
            cbLavoratore.Items.Clear(); ///Pulisco l'elenco

            if (result != "")
            {
                ElencoLavoratori = Lavoratore.GeneraElencoLavoratori(result);

                cbLavoratore.Enabled = true; ///Abilito la selezione               

                ///Popolo la combo box
                cbLavoratore.DisplayMember = "Text";
                cbLavoratore.ValueMember = "Value";
                foreach (Lavoratore lavoratore in ElencoLavoratori)
                    cbLavoratore.Items.Add(new { Text = lavoratore.Nome + " " + lavoratore.Cognome, 
                                                 Value = lavoratore });
            }

            else
                MessageBox.Show("ERRORE! Impossibile ottenere i dati dal DB, contattare l'amministrazione.", "CaricaCBLavoratori FormPartecipanti", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        /// <summary>
        /// Funzione adibita all'inserimento di un nuovo partecipante ad un'Attività
        /// </summary>
        private void AggiungiPartecipante()
        {
            
            string ruolo = "Partecipante";

            if ((tipologia == "Progetto") || (tipologia == "progetto"))
                ruolo = cbRuolo.Text;

            string usernamePartecipante = (cbLavoratore.SelectedItem as dynamic).Value.Username;
            string output_nomeCognome = (cbLavoratore.SelectedItem as dynamic).Value.Nome + " " + (cbLavoratore.SelectedItem as dynamic).Value.Cognome;

            if (Controller.AggiugniPartecipanteAttivita(usernamePartecipante, Att.Codice, ruolo))
                MessageBox.Show("Inserimento partecipante " + output_nomeCognome + " avvenuto con successo!", "FormPartecipanti", MessageBoxButtons.OK, MessageBoxIcon.Information);

            else
                MessageBox.Show("Errore in fase d'inserimento.", "FormPartecipanti", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                      
        }

        /// <summary>
        /// Metodo per aggiornare i dati presenti nella dgvPartecipanti
        /// </summary>
        public void AggiornadgvPartecipanti()
        {
            string result = "";

            dgvPartecipanti.Rows.Clear();
            CaricaCBLavoratori(); ///Ricarico la combobox per aggiornare i lavoratori disponibili ed evitare di avere doppioni
            
            result = Controller.GetElencoPartecipantiAttivita(Att.Codice);

            if (result != "")
            {
                List<string> elencoPartecipazioni = result.Split('\n').ToList();
                elencoPartecipazioni.RemoveAt((elencoPartecipazioni.Count - 1)); ///A causa dello split l'ultimo elemento rimane vuoto --> ""

                foreach (string info in elencoPartecipazioni)
                {
                    List<string> dettagli_info = info.Split('-').ToList();
                    dgvPartecipanti.Rows.Add(dettagli_info.ElementAt(0), dettagli_info.ElementAt(1), dettagli_info.ElementAt(2));
                }
            }

            else
                MessageBox.Show("Non sono ancora presenti partecipanti per questa attivita.", "Aggiorna DGVPartecipanti", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// Funzione adibita alla validazione dei campi d'inserimento
        /// </summary>
        /// <returns></returns>
        public bool CheckCampi()
        {
            bool esito = false;

            if (cbLavoratore.Text != "")
                esito = true;
            
            else
            {
                MessageBox.Show("Seleziona un lavoratore!", "FormPartecipanti", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbLavoratore.BackColor = Color.Red;
                return false;
            }

            if ((tipologia == "Progetto") || (tipologia == "progetto"))
            {
                if (cbRuolo.Text != "")
                    esito = true;

                else
                {
                    MessageBox.Show("Seleziona un ruolo per il lavoratore!", "FormPartecipanti", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbRuolo.BackColor = Color.Red;
                    return false;
                }
            }
                         
            return esito;
        }
        #endregion
    }
}
