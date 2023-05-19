namespace Formulario
{
    public partial class Form1<T> : Form
        where T : class
    {
        public Form1()
        {
            InitializeComponent();
            int y = 0;
            int x = 0;
            foreach (var item in typeof(T).GetProperties()) 
            {
                Label label = new Label();
                label.Name = item.Name;
                label.Text = item.Name + ":";
                label.Location = new Point(x, y);
                this.Controls.Add(label);
                y += 30;
                x += 20;
            }
            
        }
    }
}
