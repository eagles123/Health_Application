var ctx2 = document.getElementById("pieChart");
data2 = {
    datasets: [{
        data: [20, 40, 40],
backgroundColor: ["rgb(255, 99, 132)", "rgb(54, 162, 235)", "rgb(255, 205, 86)"]
        }],

// These labels appear in the legend and in the tooltips when hovering different arcs
labels: [
    'Protein',
    'Carbonhydrate',
    'Fate'
]
    };

var myPieChart = new Chart(ctx2, {
    type: 'pie',
    data: data2

});