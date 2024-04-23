using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WFlab11
{
    public partial class MainForm : Form
    {
        private Subject _subject = new Subject();
        private TimeObserver _timeObserver;
        private CountObserver _countObserver;

        public MainForm()
        {
            InitializeComponent();

            _timeObserver = new TimeObserver(_subject);
            _countObserver = new CountObserver(_subject);

            _subject.Attach(_timeObserver);
            _subject.Attach(_countObserver);
        }

        private void btnSetState_Click(object sender, EventArgs e)
        {
            _subject.SetState("Some State");
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;

            if (checkBox.Name == "timeObserverCheckBox")
            {
                if (checkBox.Checked)
                    _subject.Attach(_timeObserver);
                else
                    _subject.Detach(_timeObserver);
            }
            else if (checkBox.Name == "countObserverCheckBox")
            {
                if (checkBox.Checked)
                    _subject.Attach(_countObserver);
                else
                    _subject.Detach(_countObserver);
            }
        }
    }
    public interface ISubject
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify();
        string GetState();
        void SetState(string state);
    }

    public interface IObserver
    {
        void Update();
    }

    public class Subject : ISubject
    {
        private List<IObserver> _observers = new List<IObserver>();
        private string _state;

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update();
            }
        }

        public string GetState()
        {
            return _state;
        }

        public void SetState(string state)
        {
            _state = state;
            Notify();
        }
    }

    public class TimeObserver : IObserver
    {
        private Subject _subject;

        public TimeObserver(Subject subject)
        {
            _subject = subject;
        }

        public void Update()
        {
            Console.WriteLine($"TimeObserver: Current state of Subject is {_subject.GetState()} at {DateTime.Now}");
        }
    }

    public class CountObserver : IObserver
    {
        private Subject _subject;
        private int _count = 0;

        public CountObserver(Subject subject)
        {
            _subject = subject;
        }

        public void Update()
        {
            if (_subject.GetState() == "Some State")
            {
                _count++;
                Console.WriteLine($"CountObserver: Found state 'Some State'. Count: {_count}");
            }
        }
    }

    
}
