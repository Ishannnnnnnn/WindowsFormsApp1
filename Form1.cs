using System;
using System.Windows.Forms;

public class Form1 : Form
{
    // Объявляем переменные для хранения имени, фамилии и даты рождения
    private string Name1;
    private string Name2;

    // Элементы управления
    private Label label1;
    private TextBox txtFirstName;
    private TextBox txtLastName;
    private DateTimePicker dtpBirthday;
    private Button btnDisplay;

    public Form1()
    {
        InitializeComponent();
        // Установка свойств элементов интерфейса
        label1.Text = "Введите имя, фамилию и дату рождения сотрудника.";
        btnDisplay.Text = "Отобразить запись";
    }

    // Свойства для имени и фамилии
    public string FirstName
    {
        get { return Name1; }
        set { Name1 = value; }
    }

    public string LastName
    {
        get { return Name2; }
        set { Name2 = value; }
    }

    // Метод для вычисления возраста
    public int Age(DateTime birthday)
    {
        return (int)((DateTime.Now - birthday).TotalDays / 365.25);
    }

    // Обработчик события для кнопки
    private void btnDisplay_Click(object sender, EventArgs e)
    {
        // Устанавливаем значения свойств из текстовых полей
        FirstName = txtFirstName.Text;
        LastName = txtLastName.Text;
        DateTime DOB = dtpBirthday.Value;

        // Показываем сообщение с результатами
        MessageBox.Show($"Имя: {FirstName}\nФамилия: {LastName}\nВозраст: {Age(DOB)}");
    }

    // Метод для инициализации компонентов
    private void InitializeComponent()
    {
        label1 = new Label();
        txtFirstName = new TextBox();
        txtLastName = new TextBox();
        dtpBirthday = new DateTimePicker();
        btnDisplay = new Button();
        SuspendLayout();

        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new System.Drawing.Point(12, 9);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(273, 13);
        label1.TabIndex = 0;

        // 
        // txtFirstName
        // 
        txtFirstName.Location = new System.Drawing.Point(12, 25);
        txtFirstName.Name = "txtFirstName";
        txtFirstName.Size = new System.Drawing.Size(260, 20);
        txtFirstName.TabIndex = 1;

        // 
        // txtLastName
        // 
        txtLastName.Location = new System.Drawing.Point(12, 51);
        txtLastName.Name = "txtLastName";
        txtLastName.Size = new System.Drawing.Size(260, 20);
        txtLastName.TabIndex = 2;

        // 
        // dtpBirthday
        // 
        dtpBirthday.Location = new System.Drawing.Point(12, 77);
        dtpBirthday.Name = "dtpBirthday";
        dtpBirthday.Size = new System.Drawing.Size(260, 20);
        dtpBirthday.TabIndex = 3;

        // 
        // btnDisplay
        // 
        btnDisplay.Location = new System.Drawing.Point(12, 103);
        btnDisplay.Name = "btnDisplay";
        btnDisplay.Size = new System.Drawing.Size(260, 23);
        btnDisplay.TabIndex = 4;
        btnDisplay.Click += new EventHandler(btnDisplay_Click);

        // 
        // Form1
        // 
        ClientSize = new System.Drawing.Size(284, 141);
        Controls.Add(btnDisplay);
        Controls.Add(dtpBirthday);
        Controls.Add(txtLastName);
        Controls.Add(txtFirstName);
        Controls.Add(label1);
        Name = "Form1";
        Text = "Класс Person";
        ResumeLayout(false);
        PerformLayout();
    }
}

    
