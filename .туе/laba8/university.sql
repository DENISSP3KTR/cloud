PGDMP     1    3                z            test    12.6    12.6                 0    0    ENCODING    ENCODING     !   SET client_encoding = 'WIN1251';
                      false            !           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            "           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            #           1262    16393    test    DATABASE     �   CREATE DATABASE test WITH TEMPLATE = template0 ENCODING = 'UTF8' LC_COLLATE = 'Russian_Russia.1251' LC_CTYPE = 'Russian_Russia.1251';
    DROP DATABASE test;
                postgres    false            �            1259    16394 
   exam_marks    TABLE     �   CREATE TABLE public.exam_marks (
    exam_id integer,
    student_id integer,
    subj_id integer,
    mark integer,
    exam_date date
);
    DROP TABLE public.exam_marks;
       public         heap    postgres    false            �            1259    16397    lectures    TABLE        CREATE TABLE public.lectures (
    lecturer_id integer,
    surname text,
    name text,
    city text,
    univ_id integer
);
    DROP TABLE public.lectures;
       public         heap    postgres    false            �            1259    16403    progress    TABLE     z   CREATE TABLE public.progress (
    subj_id integer,
    student_id integer,
    progress integer,
    semester integer
);
    DROP TABLE public.progress;
       public         heap    postgres    false            �            1259    16406    student    TABLE     �   CREATE TABLE public.student (
    student_id integer NOT NULL,
    surname text,
    name text,
    stipend double precision,
    kurs integer,
    city character(50),
    birthday date,
    univ_id integer
);
    DROP TABLE public.student;
       public         heap    postgres    false            �            1259    16424 	   subj_lect    TABLE     P   CREATE TABLE public.subj_lect (
    lecturer_id integer,
    subj_id integer
);
    DROP TABLE public.subj_lect;
       public         heap    postgres    false            �            1259    16412    subject    TABLE     q   CREATE TABLE public.subject (
    subj_id integer,
    subj_name text,
    hour integer,
    semester integer
);
    DROP TABLE public.subject;
       public         heap    postgres    false            �            1259    16418 
   university    TABLE     o   CREATE TABLE public.university (
    univ_id integer,
    univ_name text,
    rating integer,
    city text
);
    DROP TABLE public.university;
       public         heap    postgres    false                      0    16394 
   exam_marks 
   TABLE DATA           S   COPY public.exam_marks (exam_id, student_id, subj_id, mark, exam_date) FROM stdin;
    public          postgres    false    202   %                 0    16397    lectures 
   TABLE DATA           M   COPY public.lectures (lecturer_id, surname, name, city, univ_id) FROM stdin;
    public          postgres    false    203   �                 0    16403    progress 
   TABLE DATA           K   COPY public.progress (subj_id, student_id, progress, semester) FROM stdin;
    public          postgres    false    204                    0    16406    student 
   TABLE DATA           d   COPY public.student (student_id, surname, name, stipend, kurs, city, birthday, univ_id) FROM stdin;
    public          postgres    false    205   N                 0    16424 	   subj_lect 
   TABLE DATA           9   COPY public.subj_lect (lecturer_id, subj_id) FROM stdin;
    public          postgres    false    208   �                 0    16412    subject 
   TABLE DATA           E   COPY public.subject (subj_id, subj_name, hour, semester) FROM stdin;
    public          postgres    false    206   �                 0    16418 
   university 
   TABLE DATA           F   COPY public.university (univ_id, univ_name, rating, city) FROM stdin;
    public          postgres    false    207   M          W   x�U��� D��L/��Y�	+��:�/?�k�7$dfż��jݪ`Od�[K*ε��1F�V���X����.�����'�A�.*�            x�M�M
1������L-����J���J��$���n�y��Y�3�X)e8�����)�1��pS!�S�ԓ�V+>�)7��'��-->Ă+�<�5�ǳ��[\�N�VU;��y=�<l�1_�-m�         #   x�34�4�4�4�21�4�42�"F`V� I�9         /  x���An�0E�ߧ�R�M�����VЂz+�mHpj�ĪR;���l���ތ&l��ߺ�.���;\����(#�Mj���#3�!s�0�@g�i�\�x��N�W�ghK���]���N�Ma��O�t�þ�::+v���u0��{]SX\�r�U��?A,lx�����BNj�]/j]��$�b��#����:W�ͱ�6u�*��|_ը�<���̴���U軐�y�L�f2�������Ԥi�ŧ��ʥ0w��k�t�;��1\����s���I�G��$��&�.�R?'r         0   x����0���&�;�B�u��h/Ҳ�(�^W���P���{��3�         p   x�E�A@0E�3��q����t����"�ZJhm,�����:ܦ=E	�`�%�T��^��/k�>Y^O�kR+�N&���=�Cw���X!�Z;�c*����ǃ@�         y   x�=�A�@�=�1̰��+p]��UA������R�-��]��"Z^ҍ�@�DN��6[�1�wT�
�%���*�������q@�{�h����'q�qgZc��g\�~��u��D�B�F     