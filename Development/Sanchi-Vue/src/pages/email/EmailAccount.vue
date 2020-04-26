<template>
  <div class="account">
    <div>
      <label>邮箱账号</label>
      <input v-model="EmailAccount">
    </div>
    <div>
      <label>用户密码</label>
      <input v-model="PassWord" type="password">
    </div>
    <div>
      <label>邮箱类型</label>
      <input v-model="EmailType">
    </div>
    <div>
      <label>收件服务器</label>
      <input v-model="PickUpServer">
    </div>
    <div>
      <label>发件服务器</label>
      <input v-model="SendingServer">
    </div>
    <div>
      <label>是否使用SSL</label>
      <input v-model="IsSSL">
    </div>

  </div>
</template>

<script>
  export default {
    name: 'EmailAccount',
    data() {
      return {
        EmailAccount: '',
        PassWord: '',
        EmailType: '',
        PickUpServer: '',
        SendingServer: '',
        IsSSL: '',
      }
    },
    //在这里调用ajax请求方法
    created() {
      this.fnGetInfo();
    },

    methods: {
      fnGetInfo: function () {
        //GET
        this.$ajax({
          method: 'get',
          url: 'api/Email/GetEmailInfo',
        }).then(response => {
          var _data = response.data.data;
          // console.log(_data);
          this.EmailAccount = _data.emailAccount;
          this.PassWord = _data.passWord;
          this.EmailType = _data.emailType;
          this.PickUpServer = _data.pickUpServer;
          this.SendingServer = _data.sendingServer;
          this.IsSSL = _data.isSSL;
        }).catch(function (err) {
          console.log(err)
        });
      },
      fnSaveInfo: function () {
        //Post
        this.$ajax({
          method: 'post',
          url: 'api/Email/SetEmailInfo',
          data: {
            EmailAccount: this.EmailAccount,
            PassWord: this.PassWord,
            EmailType: this.EmailType,
            PickUpServer: this.PickUpServer,
            SendingServer: this.SendingServer,
            IsSSL: this.IsSSL
          },
        }).then(function (response) {
          console.log(response);
        }).catch(function (err) {
          console.log(err)
        });
      }
    }

  }

</script>

<style scoped>

</style>
