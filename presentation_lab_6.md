---
## Front matter
lang: ru-RU
title: Мандатное разграничение прав в Linux
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

Развить навыки администрирования ОС Linux. Получить первое практическое знакомство с технологией SELinux. Проверить работу SELinx на практике совместно с веб-сервером Apache.

# Ход выполнения работы

## Начало работы

![Запуск сервера](image\http_start.png){#fig:001}

## Начало работы

![Поиск Apache](image\apache_find.png){#fig:002}

## Начало работы

![КСостояние переключателей SELinux](image\sestatus.png){#fig:003}

## Начало работы

![Статистика по политике](image\policy.png){#fig:004}

## Создание веб-страницы

![Контекст файла с веб-страницей](image\context.png){#fig:005}

## Создание веб-страницы

![Сама веб-страница](image\result.png){#fig:006}

## Изменение конфигурации сервера и страницы

![Изменение контекста](image\samba.png){#fig:007}

## Изменение конфигурации сервера и страницы

![Веб-страница](image\samba_result.png){#fig:009}

## Изменение конфигурации сервера и страницы

![Указание 81 порта](image\port_81.png){#fig:010}

## Изменение конфигурации сервера и страницы

![Прослушивание 81 порта](image\add_81.png){#fig:011}

## Возвращение к исходным настройкам

![Указание 80 порта](image\port_80.png){#fig:012}

## Возвращение к исходным настройкам

![Удаление страницы и 81 порта](image\rm_81.png){#fig:012}

## Вывод

Я развил навыки администрирования ОС Linux, получил первое практическое знакомство с технологией SELinux и проверил работу SELinx на практике совместно с веб-сервером Apache.

