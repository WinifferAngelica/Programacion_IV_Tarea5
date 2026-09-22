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
            var estudiantes = await _httpClient.GetFromJsonAsync<List<Estudiantes>>("https://hogwartswebapi-emfgduhhb5cpbeck.centralus-01.azurewebsites.net/api/Estudiantes");
            dgvEstudiantes.DataSource = estudiantes;
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
