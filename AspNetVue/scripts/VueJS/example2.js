var vm = new Vue({
    el: '#example2',
    data: {
        message: 'Привет'
    },
    computed: {
        fullName: {
            // геттер:
            get: function () {
                return this.firstName + ' ' + this.lastName
            },
            // сеттер:
            set: function (newValue) {
                var names = newValue.split(' ')
                this.firstName = names[0]
                this.lastName = names[names.length - 1]
            }
        }
    }
})