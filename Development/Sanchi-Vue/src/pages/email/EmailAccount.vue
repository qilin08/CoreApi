<template>
  <div class="account">
    <el-form :model="form">
    <div>
      <label>邮箱账号:</label>
      <input v-model="EmailAccount">
    </div>
    <div>
      <label>用户密码:</label>
      <input v-model="PassWord" type="password">
    </div>
    <div>
      <label>邮箱类型:</label>
      <input v-model="EmailType">
    </div>
    <div>
      <label>收件服务器:</label>
      <input v-model="PickUpServer">
    </div>
    <div>
      <label>发件服务器:</label>
      <input v-model="SendingServer">
    </div>
    <div>
      <label>是否使用SSL:</label>
      <el-radio v-model="IsSSL" label='1'>是</el-radio>
      <el-radio v-model="IsSSL" label='0'>否</el-radio>
    </div>
      <el-button @click="fnSaveInfo" type="primary">更新</el-button>
    </el-form>

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
        IsSSL: '1',
        form:{}
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
          this.IsSSL = _data.isSSL?'1':'0';
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
            IsSSL: this.IsSSL==='1'?true:false
          },
        }).then(function (response) {
          console.log(response);
        }).catch(function (err) {
          console.log(err)
        });

        this.fnGetInfo();
      }
    }

  }

</script>

<style scoped>

</style>
