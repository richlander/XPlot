﻿(*** condition: prepare ***)
#r "../../bin/XPlot.GoogleCharts/netstandard2.0/XPlot.GoogleCharts.dll"
#r "../../packages/Newtonsoft.Json/lib/netstandard2.0/Newtonsoft.Json.dll"
#r "../../packages/Google.DataTable.Net.Wrapper/lib/netstandard2.0/Google.DataTable.Net.Wrapper.dll"
(*** condition: ipynb ***)
#if IPYNB
#r "nuget: XPlot.GoogleCharts"
#endif // IPYNB

(**
Google Pie Chart
================
*)
open XPlot.GoogleCharts

let data =
    [
        "Work", 11
        "Eat", 2
        "Commute", 2
        "Watch TV", 2
        "Sleep", 7
    ]

let chart =
    data
    |> Chart.Pie
    |> Chart.WithTitle "My Daily Activities"
    |> Chart.WithLegend true
(*** hide ***)
chart.GetHtml()
(*** include-it-raw ***)
