var vm = new Vue({
    el: '#example',
    data: {
        message: 'Привет'
    },
    computed: {
        // геттер вычисляемого значения
        reversedMessage: function () {
            // `this` указывает на экземпляр vm
            return this.message.split('').reverse().join('')
        }
    }
})