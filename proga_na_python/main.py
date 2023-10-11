def strange_sorter(text):
    # Разбиваем текст на слова
    words = text.split()

    # Создаем словарь для подсчета количества вхождений каждого слова
    word_count = {}
    for word in words:
        word_count[word] = word_count.get(word, 0) + 1

    # Сортируем слова по количеству вхождений в порядке убывания, а при равенстве по алфавиту
    sorted_words = sorted(words, key=lambda x: (-word_count[x], x))
    print(word_count)
    return sorted_words


# Пример использования функции
text = "Never gonna make you cry Never gonna say goodbye"
result = strange_sorter(text)
print(result)