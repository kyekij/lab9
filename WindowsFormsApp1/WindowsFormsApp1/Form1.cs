using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Subject _subject = new Subject();
        private TimeObserver _timeObserver;
        private CountObserver _countObserver;
        public Form1()
        {
            InitializeComponent();

            _timeObserver = new TimeObserver(_subject, outputTextBox);
            _countObserver = new CountObserver(_subject, outputTextBox);

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

    public class TimeObserver : IObserver
    {
        private Subject _subject;
        private TextBox _outputTextBox;
        private DateTime _startTime;

        public TimeObserver(Subject subject, TextBox outputTextBox)
        {
            _subject = subject;
            _outputTextBox = outputTextBox;
        }

        public void Update()
        {
            TimeSpan timeElapsed = DateTime.Now - _startTime;
            _outputTextBox.AppendText($"TimeObserver: Elapsed time since state change: {timeElapsed.TotalSeconds} seconds\n");
        }

        public void SetStartTime()
        {
            _startTime = DateTime.Now;
        }
    }

    public class CountObserver : IObserver
    {
        private Subject _subject;
        private TextBox _outputTextBox;
        private int _count = 0;
        private string _previousState;

        public CountObserver(Subject subject, TextBox outputTextBox)
        {
            _subject = subject;
            _outputTextBox = outputTextBox;
        }

        public void Update()
        {
            string currentState = _subject.GetState();
            if (currentState == "Some State" && currentState != _previousState)
            {
                _count++;
                _outputTextBox.AppendText($"CountObserver: Found state 'Some State'. Count: {_count}\n");
            }
            _previousState = currentState;
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

        public ICollection GetObservers()
        {
            throw new NotImplementedException();
        }
    }

}
