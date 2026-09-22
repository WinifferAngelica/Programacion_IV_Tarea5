using System.Net.Http.Json;
using WinFormsClient.Modelos;

namespace WinFormsClient
{
    public partial class Form1 : Form
    {
        private readonly HttpClient _httpClient = new HttpClient();

        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void btnCargar_Click(object sender, EventArgs e)
        {
            btnCargar.Enabled = false;
            try
            {
                var estudiantes = await _httpClient.GetFromJsonAsync<List<Estudiantes>>("https://hogwartswebapi-emfgduhhb5cpbeck.centralus-01.azurewebsites.net/api/Estudiantes");
                dgvEstudiantes.DataSource = estudiantes;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudo cargar el listado: {ex.Message}", "Error de conexión",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnCargar.Enabled = true;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
