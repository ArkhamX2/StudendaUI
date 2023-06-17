﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Studenda.View.AndroidView;

namespace Studenda.ViewModel
{
    public enum WeekType
    {
        Red, Blue
    }

    public class Subject
    {
        public string Time { get; set; }
        public string Title { get; set; }
        public string Place { get; set; }

        public Subject(string time, string title, string place)
        {
            Time = time;
            Title = title;
            Place = place;
        }
    }

    public class DaySchedule
    {
        public List<Subject> SubjectList { get; set; }
        public string DayTitle { get; set; }

        public DaySchedule(string dayTitle, List<Subject> subjectList)
        {
            DayTitle = dayTitle;
            SubjectList = subjectList;
        }

    }

    public class WeekSchedule
    {
        public List<DaySchedule> ScheduleList { get; set; }
        public WeekType CurrentWeekType { get; set; }
        public WeekSchedule(List<DaySchedule> scheduleList, WeekType currentWeekType)
        {
            ScheduleList = scheduleList;
            CurrentWeekType = currentWeekType;
        }
    }


    public partial class ScheduleViewModel : ObservableObject
    {
        [ObservableProperty]
        private WeekType typeOfWeek;

        [ObservableProperty]
        private WeekSchedule schedule;

        [ObservableProperty]
        private List<DaySchedule> scheduleList;

        public ScheduleViewModel()
        {
            TypeOfWeek = WeekType.Red;
            Schedule = new WeekSchedule(
                new List<DaySchedule>()
                {
                    new DaySchedule("Понедельник",new List<Subject>()
                    {
                        new Subject("8.30","Понедельник","вц-303"),
                        new Subject("8.30","Математика","вц-303"),
                    }),
                    new DaySchedule("Вторник",new List<Subject>()
                    {
                        new Subject("8.30","Вторник","вц-303"),
                    }),
                    new DaySchedule("Среда",new List<Subject>()
                    {
                        new Subject("8.30","Математика","вц-303"),
                        new Subject("8.30","Среда","вц-303"),
                        new Subject("8.30","Математика","вц-303"),
                    }),
                    new DaySchedule("Понедельник",new List<Subject>()
                    {
                        new Subject("8.30","Понедельник","вц-303"),
                        new Subject("8.30","Математика","вц-303"),
                        new Subject("8.30","Понедельник","вц-303"),
                        new Subject("8.30","Математика","вц-303"),
                    }),
                    new DaySchedule("Вторник",new List<Subject>()
                    {
                        new Subject("8.30","Вторник","вц-303"),
                        new Subject("8.30","Вторник","вц-303"),
                    }),
                    new DaySchedule("Среда",new List<Subject>()
                    {
                        new Subject("8.30","Математика","вц-303"),
                        new Subject("8.30","Среда","вц-303"),
                        new Subject("8.30","Среда","вц-303"),
                        new Subject("8.30","Математика","вц-303"),
                    }),
                }
                , TypeOfWeek);
            ScheduleList = Schedule.ScheduleList;
        }

        [RelayCommand]
        async private void GoToProfileView()
        {
            await Shell.Current.GoToAsync($"{nameof(ProfileView)}");
        }

    }

}
