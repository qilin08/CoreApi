import Vue from 'vue'
import Router from 'vue-router'
import EmailAccount from '@/pages/email/EmailAccount'

Vue.use(Router)

export default new Router({
  routes: [
    {
      path: '/',
      name: 'EmailAccount',
      component: EmailAccount
    }
  ]
})
