
document.getElementById('next').onclick = funtion() {
    let lists = document.querySelectorAll('.item');
    document.getElementById('slider').appendChild(lists[1]);
}

document.getElementById('prev').onclick = funtion(){
    let lists = document.querySelectorAll('.item');
    document.getElementById('slider').prepend(lists[lists.length - 1]);
}