using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Mafia
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Person> people = new ObservableCollection<Person> ();
        List<string> roles = new List<string>
        {
            "Mafia",
            "Mafia",
            "Boss",
            "Sherif",
            "Doctor",
            "Maniac",
        };

        public MainWindow()
        {
            InitializeComponent();

            playerList.ItemsSource = people;
            playerList.SelectionMode = SelectionMode.Single;
        }

        private void register_Click(object sender, RoutedEventArgs e)
        {
            if(nickname.Text == "")
            {
                MessageBox.Show("Nickname is null");
            }
            else
            {
                people.Add(new Person
                {
                    Nickname = nickname.Text,
                });

                nickname.Text = "";
            }
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            Person selectedPerson = (Person)playerList.SelectedValue;
            people.Remove(selectedPerson);

            if (selectedPerson.Nickname == bossSet.Content.ToString())
            {
                bossSet.Content = "*unsetted*";
            }

            if (selectedPerson.Nickname == sherifSet.Content.ToString())
            {
                sherifSet.Content = "*unsetted*";
            }

            if (selectedPerson.Nickname == doctorSet.Content.ToString())
            {
                doctorSet.Content = "*unsetted*";
            }

            if (selectedPerson.Nickname == maniacSet.Content.ToString())
            {
                maniacSet.Content = "*unsetted*";
            }

            for(int i=0; i< mafiaList.Items.Count; i++)
            {
                if (selectedPerson.Nickname == mafiaList.Items[i].ToString())
                {
                    mafiaList.Items.Remove(mafiaList.Items[i]);
                }
            }

            for(int i=0; i< citizensList.Items.Count; i++)
            {
                if (selectedPerson.Nickname == citizensList.Items[i].ToString())
                {
                    citizensList.Items.Remove(citizensList.Items[i]);
                }
            }
        }

        private void setRole_Click(object sender, RoutedEventArgs e)
        {
            Person selectedPerson = playerList.SelectedValue as Person;
            bool nullLists = true;

            for (int i = 0; i < mafiaList.Items.Count; i++)
            {
                if (selectedPerson.Nickname == mafiaList.Items[i].ToString())
                {
                    nullLists = false;
                }
            }

            for (int i = 0; i < citizensList.Items.Count; i++)
            {
                if (selectedPerson.Nickname == citizensList.Items[i].ToString())
                {
                    nullLists = false;
                }
            }

            if (playerList.SelectedValue == null)
            {
                MessageBox.Show("Person didn't select");
            }
            else if(selectedPerson.Nickname == bossSet.Content.ToString()||
                selectedPerson.Nickname == doctorSet.Content.ToString()||
                selectedPerson.Nickname == sherifSet.Content.ToString()||
                selectedPerson.Nickname == maniacSet.Content.ToString()||
                nullLists==false)
            {
                MessageBox.Show("This person has a role yet");
            }
            else 
            {
                if (mafiaRadioButton.IsChecked == true)
                {
                    if (mafiaList.Items.Count == 2)
                    {
                        MessageBox.Show("Mafia's list is complete");
                    }
                    else
                    {
                        selectedPerson.Role = mafiaRadioButton.Content.ToString();
                        mafiaList.Items.Add(selectedPerson.Nickname);
                    }
                    
                }
                else if (bossRadioButton.IsChecked == true)
                {
                    if (bossSet.Content.ToString() != "*unsetted*")
                    {
                        MessageBox.Show("This role is busy");
                    }
                    else
                    {
                        selectedPerson.Role = bossRadioButton.Content.ToString();
                        bossSet.Content = selectedPerson.Nickname;
                    }
                }
                else if (SherifRadioButton.IsChecked == true)
                {
                    if (sherifSet.Content.ToString() != "*unsetted*")
                    {
                        MessageBox.Show("This role is busy");
                    }
                    else
                    {
                        selectedPerson.Role = SherifRadioButton.Content.ToString();
                        sherifSet.Content = selectedPerson.Nickname;
                    }
                }
                else if (doctorRadioButton.IsChecked == true)
                {
                    if (doctorSet.Content.ToString() != "*unsetted*")
                    {
                        MessageBox.Show("This role is busy");
                    }
                    else
                    {
                        selectedPerson.Role = doctorRadioButton.Content.ToString();
                        doctorSet.Content = selectedPerson.Nickname;
                    }
                }
                else if (maniacRadioButton.IsChecked == true)
                {
                    if (maniacSet.Content.ToString() != "*unsetted*")
                    {
                        MessageBox.Show("This role is busy");
                    }
                    else
                    {
                        selectedPerson.Role = maniacRadioButton.Content.ToString();
                        maniacSet.Content = selectedPerson.Nickname;
                    }
                }
                else if (citizenRadioButton.IsChecked == true)
                {
                    selectedPerson.Role = citizenRadioButton.Content.ToString();
                    citizensList.Items.Add(selectedPerson.Nickname);
                }
                else
                {
                    MessageBox.Show("Role didn't select");
                }
            }
        }

        private void clearRole_Click(object sender, RoutedEventArgs e)
        {
            if (playerList.SelectedValue == null)
            {
                MessageBox.Show("Person didn't select");
            }
            else
            {
                Person selectedPerson = playerList.SelectedValue as Person;

                for (int i = 0; i < mafiaList.Items.Count; i++)
                {
                    if (selectedPerson.Nickname == mafiaList.Items[i].ToString())
                    {
                        mafiaList.Items.Remove(mafiaList.Items[i]);
                        selectedPerson.Role = "";
                    }
                }

                for (int i = 0; i < citizensList.Items.Count; i++)
                {
                    if (selectedPerson.Nickname == citizensList.Items[i].ToString())
                    {
                        citizensList.Items.Remove(citizensList.Items[i]);
                        selectedPerson.Role = "";
                    }
                }

                if (maniacSet.Content.ToString() == selectedPerson.Nickname)
                {
                    maniacSet.Content = "*unsetted*";
                    selectedPerson.Role = "";
                }
                
                if (doctorSet.Content.ToString() == selectedPerson.Nickname)
                {
                    doctorSet.Content = "*unsetted*";
                    selectedPerson.Role = "";
                }

                if (bossSet.Content.ToString() == selectedPerson.Nickname)
                {
                    bossSet.Content = "*unsetted*";
                    selectedPerson.Role = "";
                }

                if (sherifSet.Content.ToString() == selectedPerson.Nickname)
                {
                    sherifSet.Content = "*unsetted*";
                    selectedPerson.Role = "";
                }
            }
        }

        private void randomRole_Click(object sender, RoutedEventArgs e)
        {
            if (people.Count < 11)
            {
                MessageBox.Show("There should be at least 11 people");
            }
            else
            {
                Random rnd = new Random();

                for(int i=0; i < people.Count; i++)
                {
                    int j = rnd.Next(people.Count);

                    Person item = people[j];
                    people[j] = people[i];
                    people[i] = item;
                }

                for(int i=0; i < people.Count; i++)
                {
                    if(i < roles.Count)
                    {
                        people[i].Role = roles[i];
                    }
                    else
                    {
                        people[i].Role = "Citizen";
                    }
                }

                for(int i=0; i < people.Count; i++)
                {
                    if (people[i].Role == "Boss")
                    {
                        bossSet.Content = people[i].Nickname;
                    }
                    else if (people[i].Role == "Sherif")
                    {
                        sherifSet.Content = people[i].Nickname;
                    }
                    else if (people[i].Role == "Doctor")
                    {
                        doctorSet.Content = people[i].Nickname;
                    }
                    else if (people[i].Role == "Maniac")
                    {
                        maniacSet.Content = people[i].Nickname;
                    }
                    else if (people[i].Role == "Mafia")
                    {
                        mafiaList.Items.Add(people[i].Nickname);
                    }
                    else
                    {
                        citizensList.Items.Add(people[i].Nickname);
                    }
                }
            }
        }

        private async void save_Click(object sender, RoutedEventArgs e)
        {
            bool nullRole = false;
            for (int i = 0; i < people.Count; i++)
            {
                if (people[i].Role == "")
                {
                    nullRole = true;
                }
            }

            if (playerList.Items.Count < 11)
            {
                MessageBox.Show("There should be at least 11 people");
            }
            else if (nullRole == true)
            {
                MessageBox.Show("One or more people have't a role");
            }
            else if (nullRole == true)
            {
                MessageBox.Show("One or more people have't a role");
            }
            else if (teamName.Text == "")
            {
                MessageBox.Show("Team haven't name");
            }
            else
            {
                Team newTeam = new Team();
                newTeam.Name = teamName.Text;

                List<Person> newTeamList = new List<Person>();
                foreach(Person item in people)
                {
                    newTeamList.Add(item); 
                }
                newTeam.people = newTeamList;

                BsonDocument doc = newTeam.ToBsonDocument();
                await InsertToMongo(doc);

                teamName.Text = "";
            }
        }

        public async Task InsertToMongo(BsonDocument doc)
        {
            string connection = "mongodb://localhost";
            var client = new MongoClient(connection);
            var database = client.GetDatabase("Mafia");
            var collection = database.GetCollection<BsonDocument>("Teams");
            await collection.InsertOneAsync(doc);

            teamsList.Items.Clear();

            await Refresh();
        }

        public async Task Refresh()
        {
            string connection = "mongodb://localhost";
            var client = new MongoClient(connection);
            var database = client.GetDatabase("Mafia");
            var collection = database.GetCollection<BsonDocument>("Teams");

            var filter = new BsonDocument();

            var teamsBD = await collection.Find(filter).ToListAsync();

            foreach(var item in teamsBD)
            {
                teamsList.Items.Add(item.GetValue("Name"));
            }
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            await Refresh();
        }

        //private async void teamsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    string connection = "mongodb://localhost";
        //    var client = new MongoClient(connection);
        //    var database = client.GetDatabase("Mafia");
        //    var collection = database.GetCollection<BsonDocument>("Teams");

        //    var filter = new BsonDocument();

        //    var teamsBD = await collection.Find(filter).ToListAsync();

        //    foreach (var item in teamsBD)
        //    {
        //        var newPeople= item.GetElement("people");

        //        foreach(var person in newPeople)
        //        {

        //        }

        //        //teamsList.Items.Add(item.GetValue("Name"));
        //    }
        //}
    }
}
