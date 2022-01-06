$(function () {
    $('.datepicker').datepicker(
        {
            dateFormat: "dd-mm-yy",
            minDate: new Date(),
            maxDate: AddSubractMonths(new Date(), 2)
        }
    );
    function AddSubractMonths(date, numMonths)
    {
        var month = date.getMonth();
        var millSeconds = new Date(date).setMonth(month + numMonths);
        return new Date(millSeconds);
    }
});