function solve() {
    $.fn.datepicker = function() {
        var MONTH_NAMES = ["January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"];
        var WEEK_DAY_NAMES = ['Su', 'Mo', 'Tu', 'We', 'Th', 'Fr', 'Sa'];

        Date.prototype.getMonthName = function() {
            return MONTH_NAMES[this.getMonth()];
        };

        Date.prototype.getDayName = function() {
            return WEEK_DAY_NAMES[this.getDay()];
        };
        var $this = $(this);
        var $input = $('#date');
        var $wrapper = $('<div>').addClass('datepicker-wrapper').appendTo($this.parent()).append($this);
        $this.addClass('datepicker');
        var $datepicker = $('<div>').appendTo($wrapper).addClass('datepicker-content');

        var $controls = $('<div>').addClass('controls').appendTo($datepicker);
        var $currentMonth = $('<div>').addClass('current-month').appendTo($controls);
        var $currentDate = $('<div>').addClass('current-date').appendTo($datepicker);
        var $btn = $('<button>').addClass('btn').appendTo($controls);

        var $table = $('<table>').addClass('calendar').appendTo($datepicker);
        var $thead = $('<thead>').appendTo($table);
        var $tbody = $('<tbody>').appendTo($table);
        var $row = $('<tr>').appendTo($thead);
        for(var i = 0; i < WEEK_DAY_NAMES.length; i += 1) {
            var $currentTh = $('<th>').text(WEEK_DAY_NAMES[i]).appendTo($row);
        }
        for(var i = 0; i < 6; i += 1) {
            var $currentTr = $('<tr>');
            for(var j = 0; j < 7; j+=1) {
                var $currentTd = $('<td>').appendTo($currentTr);
            }
            $currentTr.appendTo($tbody);
        }
        var d = new Date();
        var month = d.getMonth();
        var day = d.getDate();
        var year = d.getFullYear();
        $currentDate.text(day + " " + MONTH_NAMES[month] + " " + year);

        $input.focus(function() {
            $datepicker.addClass('datepicker-content-visible');
        })
        $input.focusout(function() {
            $datepicker.removeClass('datepicker-content-visible');
        })

        // you are welcome :)
        //var date = new Date();
        //console.log(date.getDayName());
        //console.log(date.getMonthName());

        return this;
    };
}
