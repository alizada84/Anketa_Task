namespace Anketa
{
    public partial class Form1 : Form
    {
        DataBase data;
        public Form1()
        {
            InitializeComponent();
            data = new DataBase();
        }
        bool checking = true;

        void Save_Checking(object sender, EventArgs e)
        {
            if (checking)
            {
                string genderText = rBtnFemale.Text;
                Gender gender;
                if (genderText == "Male")
                    gender = Gender.Male;
                else if (genderText == "Female")
                    gender = Gender.Female;
                else
                    gender = Gender.Male;

                DateTime birthDayTime;
                birthDayTime = birthDay.Value.Date;

                try
                {
                    Person person = new Person
                    (
                        textName.Text, textSurname.Text, textFatherName.Text, textCounty.Text, textCity.Text, textEmail.Text, textPhone.Text,
                        gender, birthDayTime
                    );

                    data.AddPerson(person);

                    checking = false;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                }
                
                
            }
            else
                MessageBox.Show("All Changes Saves", "Info", MessageBoxButtons.OK);
        }
    }
}