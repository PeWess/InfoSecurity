---
## Front matter
lang: ru-RU
title: Дискреционное разграничение прав в Linux. Исследование влияния дополнительных атрибутов.
author: |
	Критский Сергей Димитриевич

## Formatting
toc: false
slide_level: 2
theme: metropolis
header-includes: 
 - \metroset{progressbar=frametitle,sectionpage=progressbar,numbering=fraction}
 - '\makeatletter'
 - '\beamer@ignorenonframefalse'
 - '\makeatother'
 - \usepackage[T2A]{fontenc}
aspectratio: 43
section-titles: true
---

## Цель работы

Изучение механизмов изменения идентификаторов, применения SetUID- и Sticky-битов. Получение практических навыков работы в консоли с дополнительными атрибутами. Рассмотрение работы механизма смены идентификатора процессов пользователей, а также влияние бита Sticky на запись и удаление файлов.

# Ход выполнения работы

## Программа 1

![Код программы](image\prog_1.png){#fig:001}

## Программа 1

![Результат выполнения](image\result_1.png){#fig:002}

## Программа 2

![Код программы](image\prog_2.png){#fig:003}

## Программа 2

![Пользователь guest](image\guest_result.png){#fig:004}

## Программа 2

![Суперпользователь](image\super_result.png){#fig:005}

## Программа 3

![Код программы](image\prog_3.png){#fig:006}

## Программа 3

![Результат выполнения на примере readfile.c](image\result_3.png){#fig:007}

## Исследование Sticky-бита

![Взаимодействие с файлом в директирии со Sticky-битом](image\sticky.png){#fig:009}

## Исследование Sticky-бита

![Взаимодействие с файлом в директирии без Sticky-бита](image\sticky_2.png){#fig:010}

## Вывод

Я изучил механизмы изменения идентификаторов, применения SetUID- и Sticky-битов. Получил практические навыки работы в консоли с дополнительными атрибутами. Рассмотрел работу механизма смены идентификатора процессов пользователей, а также влияние бита Sticky на запись и удаление файлов.

