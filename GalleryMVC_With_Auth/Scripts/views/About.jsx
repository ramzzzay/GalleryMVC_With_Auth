﻿var About = React.createClass({
    render: function () {
        return (
            <div>
<h2>О нас.</h2>

<p>Лучше картины на планете, я гарантирую это!</p>
<p>
<b>Жанна Воробьева</b> родилась 14 января 1974 г в г.Пинске.
    В 1989 г. закончила подготовительные курсы Пинской детской школы изобразительного искусства (преподаватели: Е.Шатохин, С.Хорошавцев).
    В том же году поступила в Минский художественный колледж при Белорусской Академии искусств, который окончила в 1993 г. (преподаватели: И.Власов, М.Нацевский).
    С 1994 года по настоящее время работает преподавателем в Пинской детской школе изобразительного искусства.
    Принимала участие в коллективных выставках:
    1995,1996,1998,2001,2004 г.г. – г.Пинск
    1995,2004,2005 г.г. – г.Брест
    1998 г. – г.Хунген-Утфе (Германия)
    2000, 2002 г.г. – Хунген-Виллинген (Германия)
    2004 г. – Варшава (Польша)
    2004,2005 г.г. – г.Минск
    Персональные выставки:
    2002 г. – г.Пинск
    2003 г. – г.Брест
    2005 г - г.Брест «Полесская палитра» (художественная галерея «БелАрт»)
</p>
            </div>
        );
    }
});


React.render(<About />, document.getElementById("about"));