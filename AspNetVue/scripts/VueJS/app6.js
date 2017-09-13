
var myTask = Vue.component('todo-item', {
    template: '<li>Это todo</li>'
})

var app6 = new Vue({
    el: '#app-6',
    data: {
       
    },
    methods: {
        reverseMessage: function (e) {
            console.log(e);
        }
    },
    components: {
        myTask: myTask 
    },
    computed: {
      
    },
    ready: function (e) {
        console.log(e);
    }
})

