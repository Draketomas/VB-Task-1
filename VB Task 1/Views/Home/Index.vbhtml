@Code
    ViewData("Title") = "Home Page"
End Code


<div class="row">
    <div class="col-md-4">
        <h2>Enter Prices</h2>
        <div>@Html.ActionLink("Enter Prices", "Create", "Prices")</div>
    </div>
    <div class="col-md-4">
        <h2>Create Parts</h2>
        <div>@Html.ActionLink("Create Parts", "Create", "Parts")</div>
    </div>
    <div class="col-md-4">
        <h2>View Parts</h2>
        <div>@Html.ActionLink("Parts List", "Index", "Parts")</div>
    </div> 
</div>
