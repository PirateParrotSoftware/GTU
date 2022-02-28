using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;
using Zenject;

public class Report
{
    public readonly Guid Id;

    public Report(Guid id)
    {
        Id = id;
    }
}

public class ReportQueue : IInitializable, IDisposable
{
    public ReactiveCollection<Report> Reports { get; private set; } = new ReactiveCollection<Report>();

    public void AddReport(Report report)
    {
        
    }
    
    public void Initialize()
    {
        
    }

    public void Dispose()
    {
        
    }
}
