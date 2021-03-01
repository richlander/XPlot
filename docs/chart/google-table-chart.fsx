﻿(*** condition: prepare ***)
#r "../../bin/XPlot.GoogleCharts/netstandard2.0/XPlot.GoogleCharts.dll"
#r "../../packages/Newtonsoft.Json/lib/netstandard2.0/Newtonsoft.Json.dll"
#r "../../packages/Google.DataTable.Net.Wrapper/lib/netstandard2.0/Google.DataTable.Net.Wrapper.dll"
(*** condition: ipynb ***)
#if IPYNB
#r "nuget: XPlot.GoogleCharts"
#endif // IPYNB

(**
Google Table Chart
==================
*)
open XPlot.GoogleCharts

let salary =
    [
        "Mike", 10000
        "Jim", 8000
        "Alice", 12500
        "Bob", 7000
    ]
    |> List.map (fun (x, y) -> x, y :> value)

let fulltime =
    [
        "Mike", true
        "Jim", false
        "Alice", true
        "Bob", true
    ]
    |> List.map (fun (x, y) -> x, y :> value)

let chart =
    [salary; fulltime]
    |> Chart.Table
    |> Chart.WithOptions(Options(showRowNumber = true))
    |> Chart.WithLabels ["Name"; "Salary"; "Full Time Employee"]
(*** hide ***)
chart.GetHtml()
(*** include-it-raw ***)
