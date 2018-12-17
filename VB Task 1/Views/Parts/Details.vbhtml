@ModelType VB_Task_1.Models.Parts
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>Parts</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            Price
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.PriceRef.PriceValue)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.PartNumber)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.PartNumber)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Description)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Description)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.ID }) |
    @Html.ActionLink("Back to List", "Index")
</p>
