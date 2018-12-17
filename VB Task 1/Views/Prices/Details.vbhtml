@ModelType VB_Task_1.Models.Price
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>Price</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.PriceValue)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.PriceValue)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.ID }) |
    @Html.ActionLink("Back to List", "Index")
</p>
