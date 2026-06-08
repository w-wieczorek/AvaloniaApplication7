using System;

namespace GradeScaleApp.ViewModels;

public class MainViewModel : ViewModelBase
{
    private const double MinGrade = 3.0;
    private const double MaxGrade = 5.0;

    private double _pMin = 50;
    private double _pMax = 100;
    private double _studentPercent = 73;

    public double PMin
    {
        get => _pMin;
        set
        {
            if (SetProperty(ref _pMin, Math.Round(value)))
            {
                NormalizeRange();
                Recalculate();
            }
        }
    }

    public double PMax
    {
        get => _pMax;
        set
        {
            if (SetProperty(ref _pMax, Math.Round(value)))
            {
                NormalizeRange();
                Recalculate();
            }
        }
    }

    public double StudentPercent
    {
        get => _studentPercent;
        set
        {
            if (SetProperty(ref _studentPercent, Math.Round(value)))
            {
                Recalculate();
            }
        }
    }

    public double PMid => Math.Round((PMin + PMax) / 2.0);

    public double StudentGrade => Math.Round(Clamp(CalculateGrade(StudentPercent), MinGrade, MaxGrade), 2);

    public double StudentPointX => MapPercentToX(Clamp(StudentPercent, PMin, PMax));

    public double StudentPointY => MapGradeToY(StudentGrade);

    public double StudentPointLeft => StudentPointX - 5;

    public double StudentPointTop => StudentPointY - 5;

    private void NormalizeRange()
    {
        if (_pMax <= _pMin)
        {
            _pMax = _pMin + 1;
            OnPropertyChanged(nameof(PMax));
        }
    }

    private void Recalculate()
    {
        OnPropertyChanged(nameof(PMid));
        OnPropertyChanged(nameof(StudentGrade));
        OnPropertyChanged(nameof(StudentPointX));
        OnPropertyChanged(nameof(StudentPointY));
        OnPropertyChanged(nameof(StudentPointLeft));
        OnPropertyChanged(nameof(StudentPointTop));
    }

    private double CalculateGrade(double percent)
    {
        var ratio = (percent - PMin) / (PMax - PMin);
        return MinGrade + ratio * (MaxGrade - MinGrade);
    }

    private double MapPercentToX(double percent)
    {
        var ratio = (percent - PMin) / (PMax - PMin);
        return 70 + ratio * 450;
    }

    private static double MapGradeToY(double grade)
    {
        var ratio = (grade - MinGrade) / (MaxGrade - MinGrade);
        return 260 - ratio * 230;
    }

    private static double Clamp(double value, double min, double max)
    {
        if (value < min)
        {
            return min;
        }

        return value > max ? max : value;
    }
}
