<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="chart.aspx.cs" Inherits="grafico.chart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <script type="text/javascript">

        var options = {
            responsive: true,
            legendTemplate: "<ul class=\"chart-legend\"><li><span style=\"background-color:#F7464A\"></span>Não Iniciados</li><li><span style=\"background-color:#46BFBD\"></span>Concluídos</li><li><span style=\"background-color:#FDB45C\"></span>Em Andamento</li></ul>"
        };

        var randomnb = function () { return Math.round(Math.random() * 300) };

        var data = [
            {
                value: randomnb(),
                color: "#F7464A",
                highlight: "#FF5A5E",
                label: "Não Iniciados"
            },
            {
                value: randomnb(),
                color: "#46BFBD",
                highlight: "#5AD3D1",
                label: "Concluídos"
            },
            {
                value: randomnb(),
                color: "#FDB45C",
                highlight: "#FFC870",
                label: "Em Andamento"
            }
        ]

        window.onload = function () {

            var ctx = document.getElementById("GraficoPizza").getContext("2d");

            debugger;

            var PizzaChart = new Chart(ctx).Pie(data, options);

            PizzaChart.generateLegend();

            document.getElementById("GraficoPizza").parentNode.appendChild.innerHTML = PizzaChart.generateLegend();

        }

        

    </script>

    <div class="box-chart">
        <canvas id="GraficoPizza" style="width:100%;"></canvas>
    </div>

</asp:Content>
