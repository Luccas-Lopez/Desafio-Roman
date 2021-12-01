import React, {Component} from 'react';
import {
  StyleSheet,
  Text,
  TouchableOpacity,
  View,
  Image,
  ImageBackground,
  TextInput,
} from 'react-native';

import AsyncStorage from '@react-native-async-storage/async-storage';

import api from '../services/api';

export default class Login extends Component {
    constructor(props) {
        super(props);
        this.state = {
            email: 'lucas@gmail.com',
            senha: 'LucasGamer123',
        };
    }

    realizarLogin = async () => {
        //nao temos mais  console log.
        //vamos utilizar console.warn.
    
        //apenas para teste.
        console.warn(this.state.email + ' ' + this.state.senha);
    
        const resposta = await api.post('/login', {
          email: this.state.email, //ADM@ADM.COM
          senha: this.state.senha, //senha123
        });

    const token = resposta.data.token;
    await AsyncStorage.setItem('userToken', token);

    if (resposta.status == 200){
        console.warn('Login Realizado');
        this.props.navigation.navigate('');
    
    }

    console.warn(token);

};
   
    render() {
        return (
            <ImageBackground

                source={require('../../assets/background-login.png')}
                style={StyleSheet.absoluteFillObject}>

                <View style={styles.main}>

                    <Image
                        source={require('../../assets/Logo-Roman.png')}
                        style={styles.mainImgLogin}
                    />

                    <TextInput
                        style={styles.inputLogin}
                        placeholder="username"
                        placeholderTextColor="#FFF"
                        keyboardType="email-address"
                        // ENVENTO PARA FAZERMOS ALGO ENQUANTO O TEXTO MUDA
                        onChangeText={email => this.setState({ email })}
                    />

                    <TextInput
                        style={styles.inputLogin}
                        placeholder="password"
                        placeholderTextColor="#FFF"
                        keyboardType="default" //para default nao obrigatorio.
                        secureTextEntry={true} //proteje a senha.
                        // ENVENTO PARA FAZERMOS ALGO ENQUANTO O TEXTO MUDA
                        onChangeText={senha => this.setState({ senha })}
                    />

                    <TouchableOpacity
                        style={styles.btnLogin}
                        onPress={this.realizarLogin}>
                        <Text style={styles.btnLoginText}>Login</Text>
                    </TouchableOpacity>
                </View>
            </ImageBackground>

        );
    }
}


const styles = StyleSheet.create({
    main: {
        // flex: 1,
        //backgroundColor: '#F1F1F1', retirar pra nao ter conflito.
        justifyContent: 'center',
        alignItems: 'center',
        width: '100%',
        height: '100%',
    },

    mainImgLogin: { 
        //confirmar que sera branco
        height: 105, //altura
        width: 110, //largura img nao é quadrada
        margin: 60, //espacamento em todos os lados,menos pra cima.
        marginTop: 0, // tira espacamento pra cima
    },

    inputLogin: {
        width: 240, //largura mesma do botao
        marginBottom: 40, //espacamento pra baixo
        fontSize: 18,
        color: '#FFF',
        borderBottomColor: '#FFF', //linha separadora
        borderBottomWidth: 2, //espessura.
    },

    btnLoginText: {
        fontSize: 12, //aumentar um pouco
        fontFamily: 'Open Sans Light', //troca de fonte
        color: '#B727FF', //mesma cor identidade
        letterSpacing: 6, //espacamento entre as letras
        textTransform: 'uppercase', //estilo maiusculo
    },
    btnLogin: {
        alignItems: 'center',
        justifyContent: 'center',
        height: 38,
        width: 240,
        backgroundColor: '#FFFFFF',
        borderColor: '#FFFFFF',
        borderWidth: 1,
        borderRadius: 4,
        shadowOffset: { height: 1, width: 1 },
    },
});

