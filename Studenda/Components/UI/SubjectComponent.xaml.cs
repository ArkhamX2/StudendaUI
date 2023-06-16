namespace Studenda.Components.UI;

public partial class SubjectComponent : ContentView
{
    public static readonly BindableProperty SubjectTimeProperty = BindableProperty.Create(nameof(SubjectTime), typeof(string), typeof(SubjectComponent),
        propertyChanged: (bindable, oldValue, newValue) =>
        {
            var control = (SubjectComponent)bindable;

            control.SubjectTimeLabel.Text = newValue as string;
        });

    public static readonly BindableProperty SubjectTitleProperty = BindableProperty.Create(nameof(SubjectTitle), typeof(string), typeof(SubjectComponent),
        propertyChanged: (bindable, oldValue, newValue) =>
        {
            var control = (SubjectComponent)bindable;

            control.SubjectTitleLabel.Text = newValue as string;
        });

    public static readonly BindableProperty SubjectPlaceProperty = BindableProperty.Create(nameof(SubjectPlace), typeof(string), typeof(SubjectComponent),
        propertyChanged: (bindable, oldValue, newValue) =>
        {
            var control = (SubjectComponent)bindable;

            control.SubjectPlaceLabel.Text = newValue as string;
        });


    public SubjectComponent()
    {
        InitializeComponent();
    }

    public string SubjectTime
    {
        get => GetValue(SubjectTimeProperty) as string;
        set => SetValue(SubjectTimeProperty, value);
    }

    public string SubjectTitle
    {
        get => GetValue(SubjectTitleProperty) as string;
        set => SetValue(SubjectTitleProperty, value);
    }

    public string SubjectPlace
    {
        get => GetValue(SubjectPlaceProperty) as string;
        set => SetValue(SubjectPlaceProperty, value);
    }
}