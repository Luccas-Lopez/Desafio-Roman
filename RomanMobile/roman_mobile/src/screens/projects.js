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


export default class Projetos extends Component {
    constructor(props) {
        super(props);
        this.state = {
            listasProjetos: [],
        };
    }

    render() {
        return (
            


        );
    }
}