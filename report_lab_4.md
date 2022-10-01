---
# Front matter
title: "Лабораторная работа #4"
subtitle: "Дискреционное разграничение прав в Linux. Расширенные атрибуты."
author: "Критский Сергей Димитриевич"

# Generic otions
lang: ru-RU
toc-title: "Содержание"

# Bibliography
bibliography: bib/cite.bib
csl: pandoc/csl/gost-r-7-0-5-2008-numeric.csl

# Pdf output format
toc: true # Table of contents
toc_depth: 2
lof: false # List of figures
lot: false # List of tables
fontsize: 12pt
linestretch: 1.5
papersize: a4
documentclass: scrreprt
## I18n
polyglossia-lang:
  name: russian
  options:
	- spelling=modern
	- babelshorthands=true
polyglossia-otherlangs:
  name: english
### Fonts
mainfont: PT Serif
romanfont: PT Serif
sansfont: PT Sans
monofont: PT Mono
mainfontoptions: Ligatures=TeX
romanfontoptions: Ligatures=TeX
sansfontoptions: Ligatures=TeX,Scale=MatchLowercase
monofontoptions: Scale=MatchLowercase,Scale=0.9
## Biblatex
biblatex: true
biblio-style: "gost-numeric"
biblatexoptions:
  - parentracker=true
  - backend=biber
  - hyperref=auto
  - language=auto
  - autolang=other*
  - citestyle=gost-numeric
## Misc options
indent: true
header-includes:
  - \linepenalty=10 # the penalty added to the badness of each line within a paragraph (no associated penalty node) Increasing the value makes tex try to have fewer lines in the paragraph.
  - \interlinepenalty=0 # value of the penalty (node) added after each line of a paragraph.
  - \hyphenpenalty=50 # the penalty for line breaking at an automatically inserted hyphen
  - \exhyphenpenalty=50 # the penalty for line breaking at an explicit hyphen
  - \binoppenalty=700 # the penalty for breaking a line at a binary operator
  - \relpenalty=500 # the penalty for breaking a line at a relation
  - \clubpenalty=150 # extra penalty for breaking after first line of a paragraph
  - \widowpenalty=150 # extra penalty for breaking before last line of a paragraph
  - \displaywidowpenalty=50 # extra penalty for breaking before last line before a display math
  - \brokenpenalty=100 # extra penalty for page breaking after a hyphenated line
  - \predisplaypenalty=10000 # penalty for breaking before a display
  - \postdisplaypenalty=0 # penalty for breaking after a display
  - \floatingpenalty = 20000 # penalty for splitting an insertion (can only be split footnote in standard LaTeX)
  - \raggedbottom # or \flushbottom
  - \usepackage{float} # keep figures where there are in the text
  - \usepackage[T2A]{fontenc} 
  - \floatplacement{figure}{H} # keep figures where there are in the text
---

# Цель работы

Получение практических навыков работы в консоли с расширенными атрибутами файлов.

# Выполнение лабораторной работы

## Расширенный атрибут a

Установил начальные права на file1 и попытался установить расширенный атрибут.

![Установка атрбутов](image\attribute.png){#fig:001}

Установил атрибут с суперпользователя.

![Установка специального атрибута](image\superuser.png){#fig:002}

Проверил правильность установки атрибута и попытался взаимодействовать с файлом.

![Команда lsattr](image\lsattr.png){#fig:003}

![Запись, дозапись, переименовывание, удаление и изменение атрибутов файла](image\file_interaction.png){#fig:004}

Удалось только записать данные в файл и прочитать его, все остальное было запрещено. Снял расширенный атрибут с файла и перепроверил команды.

![Работа с файлом без атрибута](image\file_no_attr.png){#fig:005}

## Расширенный атрибут i

Восстановил файл и установил на него атрибут i. Повторил все действия.

![Повтор действий](image\repeat.png){#fig:006}

Абсолютно все действия были запрещены.

# Выводы

Я приобрел практические навыки работы в консоли с расширенными атрибутами файлов.
