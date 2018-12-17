@ModelType VB_Task_1.Models.Parts
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>Parts</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.PriceRef.ID)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.PriceRef.ID)
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
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
